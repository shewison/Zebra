using System;
using System.Linq;
using System.Collections.Generic;
using SMH.Zebra;
using SMH.iOS.Zebra;
using Xamarin.Forms;
using Foundation;
using CoreBluetooth;
using System.Timers;

[assembly: Dependency(typeof(ZebraPlatformManager))]
namespace SMH.iOS.Zebra
{
    public class ZebraPlatformManager : EventReceiver, IZebraManager, IISbtSdkApiDelegate
    {

        private IISbtSdkApi apiInstance;
        private EventReceiver apiDelegate;

        public List<IZebraScanner> Scanners { get; set; }

        private static ZebraPlatformManager _instance;

        public static ZebraPlatformManager Current
        {
            get
            {
                return _instance ?? (_instance = new ZebraPlatformManager());
            }
        }

        public Func<List<IZebraScanner>> GetScanners { get; set; }
        public Action ScannersChanged { get; set; }
        public Action<string> BarcodeRead { get; set; }

        NSMutableArray nativeScanners = new NSMutableArray();

        public void Start()
        {

        }

        NSTimer initTimer;

        public ZebraPlatformManager()
        {

            CBCentralManager cbManager = new CBCentralManager();

            _instance = this;

            if (CBManager.Authorization == CBManagerAuthorization.AllowedAlways || CBManager.Authorization == CBManagerAuthorization.Restricted)
            {
                Init();
            }
            else
            {
                initTimer = NSTimer.CreateScheduledTimer(2, true, (sender) =>
                {
                    if (CBCentralManager.Authorization == CBManagerAuthorization.AllowedAlways || CBCentralManager.Authorization == CBManagerAuthorization.Restricted)
                    {
                        Init();
                        initTimer.Invalidate();
                    }
                });

            }

        }

        private void InitTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        private void Init()
        {

            try
            {

                Scanners = new List<IZebraScanner>();

                apiInstance = SMH.iOS.Zebra.SbtSdkFactory.CreateSbtSdkApiInstance();

                apiDelegate = new EventReceiver();

                apiDelegate.SbtEventScannerAppearedCallback = SbtEventScannerAppearedHandler;
                apiDelegate.SbtEventScannerDisappearedCallback = SbtEventScannerDisappearedHandler;
                apiDelegate.SbtEventBarcodeCallback = SbtEventBarcodeHandler;

                var result = apiInstance.SbtSetOperationalMode((int)SbtOpmode.Mfi);

                apiInstance.SbtSetDelegate(apiDelegate);

                result = apiInstance.SbtEnableAvailableScannersDetection(true);

                result = apiInstance.SbtSubsribeForEvents((int)(SbtEvent.ScannerAppearance | SbtEvent.ScannerDisappearance | SbtEvent.Barcode));

                GetScanners = () => Scanners;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        SbtScannerInfo connectedScanner = null;
        
        private void SbtEventBarcodeHandler(string barcode, int barcodeType, int scannerID)
        {
            BarcodeRead?.Invoke(barcode);
        }

        string _activeScannerName = null;

        private void SbtEventScannerAppearedHandler(SbtScannerInfo scanner)
        {
            if (Scanners.Count(m => m.ScannerName == scanner.ScannerName) == 0)
            {
                Scanners.Add(new ZebraScanner(scanner));
                ScannersChanged?.Invoke();
            }

            if (_activeScannerName != null)
            {
                if (scanner.ScannerName == _activeScannerName)
                {
                    connectedScanner = scanner;
                    apiInstance.SbtEstablishCommunicationSession(scanner.ScannerID);
                    apiInstance.SbtEnableAutomaticSessionReestablishment(true, scanner.ScannerID);
                }
            }

        }

        public void RegisterActiveDevice(string scannerName)
        {
            _activeScannerName = scannerName;
        }

        public void Connect(IZebraScanner scanner)
        {
            var s = (ZebraScanner)scanner;
            connectedScanner = s.Scanner;
            apiInstance.SbtEstablishCommunicationSession(scanner.ScannerID);
            apiInstance.SbtEnableAutomaticSessionReestablishment(true, scanner.ScannerID);
        }

        public void Disconnect()
        {
            _activeScannerName = null;
            if (connectedScanner != null)
            {
                apiInstance.SbtEnableAutomaticSessionReestablishment(false, connectedScanner.ScannerID);
                apiInstance.SbtTerminateCommunicationSession(connectedScanner.ScannerID);
            }
        }

        private void SbtEventScannerDisappearedHandler(int scannerID)
        {
            Scanners = Scanners.Where(m => m.ScannerID != scannerID).ToList();
            ScannersChanged?.Invoke();
        }

    }
}