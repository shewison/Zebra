using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SMH.Zebra
{
    public class ZebraManager
    {

        private static ZebraManager _instance;

        public static ZebraManager Current => _instance ?? (_instance = new ZebraManager());

        private IZebraManager _platformManager;

        private ZebraManager()
        {

            _platformManager = DependencyService.Get<IZebraManager>();
            _platformManager.ScannersChanged = ScannersChanged;
            _platformManager.BarcodeRead = BarcodeRead;
            Scanners = new ObservableCollection<IZebraScanner>();

        }

        public delegate void OnBarcodeReadDelegate(string barcode);
        public event OnBarcodeReadDelegate OnBarcodeRead;

        private void BarcodeRead(string barcode)
        {
            OnBarcodeRead?.Invoke(barcode);
            //App.Current.MainPage.DisplayAlert("Barcode Read", barcode, "Close");
        }

        public ObservableCollection<IZebraScanner> Scanners { get; set; }

        private void ScannersChanged()
        {

            var ss = _platformManager.GetScanners();

            var remove = new List<IZebraScanner>();

            foreach (var s in Scanners)
            {
                if (ss.Count(m => m.ScannerID == s.ScannerID) == 0)
                    remove.Add(s);
            }

            foreach (var s in remove)
                Scanners.Remove(s);

            foreach (var s in ss)
            {
                if (Scanners.Count(m => m.ScannerID == s.ScannerID) == 0)
                    Scanners.Add(s);
            }

        }

        public void LinkScanner(IZebraScanner scanner)
        {
            
            _platformManager.Connect(scanner);

        }

        public void UnlinkScanner()
        {
            _platformManager.Disconnect();
        }

        public void Start()
        {
            _platformManager.Start();
        }

    }
}