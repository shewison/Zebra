using System;
using System.Collections.Generic;
namespace SMH.Zebra
{
    public interface IZebraManager
    {

        Func<List<IZebraScanner>> GetScanners { get; set; }

        Action ScannersChanged { get; set; }
        Action<string> BarcodeRead { get; set; }

        void Connect(IZebraScanner scanner);
        void Disconnect();

        void RegisterActiveDevice(string scannerName);

        void Start();

    }
}