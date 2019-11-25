using System;
namespace SMH.Zebra
{

    public interface IZebraScanner
    {
        string ScannerName { get; }
        int ScannerID { get; }
    }
}