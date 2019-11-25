using System;
using SMH.iOS.Zebra;
using Xamarin.Forms;

[assembly: Dependency(typeof(ZebraScanner))]
namespace SMH.iOS.Zebra
{
    public class ZebraScanner : SMH.Zebra.IZebraScanner
    {

        public SbtScannerInfo Scanner { get; private set; }

        public string ScannerName => Scanner.ScannerName;

        public int ScannerID => Scanner.ScannerID;

        public ZebraScanner(SbtScannerInfo scanner)
        {

            Scanner = scanner;



        }
    }
}