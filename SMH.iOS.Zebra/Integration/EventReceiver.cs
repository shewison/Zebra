using System;
using Foundation;

namespace SMH.iOS.Zebra
{
    public class EventReceiver : SMH.iOS.Zebra.ISbtSdkApiDelegate
    {
        public EventReceiver()
        {
        }

        public Action<string, int, int> SbtEventBarcodeCallback { get; set; }

        public override void SbtEventBarcode(string barcodeData, int barcodeType, int scannerID)
        {
            SbtEventBarcodeCallback?.Invoke(barcodeData, barcodeType, scannerID);
        }

        public Action<NSData, int, int> StbEventBarcodeDataCallback { get; set; }

        public override void SbtEventBarcodeData(NSData barcodeData, int barcodeType, int scannerID)
        {
            StbEventBarcodeDataCallback?.Invoke(barcodeData, barcodeType, scannerID);
        }

        public Action<SbtScannerInfo> SbtEventCommunicationSessionEstablishedCallback { get; set; }

        public override void SbtEventCommunicationSessionEstablished(SbtScannerInfo activeScanner)
        {
            SbtEventCommunicationSessionEstablishedCallback?.Invoke(activeScanner);
        }

        public Action<int> SbtEventCommunicationSessionTerminatedCallback { get; set; }

        public override void SbtEventCommunicationSessionTerminated(int scannerID)
        {
            SbtEventCommunicationSessionTerminatedCallback?.Invoke(scannerID);
        }

        public Action<FirmwareUpdateEvent> SbtEventFirmwareUpdateCallback { get; set; }

        public override void SbtEventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj)
        {
            SbtEventFirmwareUpdateCallback?.Invoke(fwUpdateEventObj);
        }

        public Action<NSData, int> SbtEventImageCallback { get; set; }

        public override void SbtEventImage(NSData imageData, int scannerID)
        {
            SbtEventImageCallback?.Invoke(imageData, scannerID);
        }

        public Action<SbtScannerInfo> SbtEventScannerAppearedCallback { get; set; }

        public override void SbtEventScannerAppeared(SbtScannerInfo availableScanner)
        {
            SbtEventScannerAppearedCallback?.Invoke(availableScanner);
        }

        public Action<int> SbtEventScannerDisappearedCallback { get; set; }

        public override void SbtEventScannerDisappeared(int scannerID)
        {
            SbtEventScannerDisappearedCallback?.Invoke(scannerID);
        }

        public Action<NSData, int> SbtEventVideoCallback { get; set; }

        public override void SbtEventVideo(NSData videoFrame, int scannerID)
        {
            SbtEventVideoCallback?.Invoke(videoFrame, scannerID);
        }
    }
}
