//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace SMH.iOS.Zebra
{
    [Protocol(Name = "ISbtSdkApiDelegate", WrapperType = typeof(ISbtSdkApiDelegateWrapper))]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventScannerAppeared", Selector = "sbtEventScannerAppeared:", ParameterType = new Type[] { typeof(SMH.iOS.Zebra.SbtScannerInfo) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventScannerDisappeared", Selector = "sbtEventScannerDisappeared:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventCommunicationSessionEstablished", Selector = "sbtEventCommunicationSessionEstablished:", ParameterType = new Type[] { typeof(SMH.iOS.Zebra.SbtScannerInfo) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventCommunicationSessionTerminated", Selector = "sbtEventCommunicationSessionTerminated:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventBarcode", Selector = "sbtEventBarcode:barcodeType:fromScanner:", ParameterType = new Type[] { typeof(string), typeof(int), typeof(int) }, ParameterByRef = new bool[] { false, false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventBarcodeData", Selector = "sbtEventBarcodeData:barcodeType:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(int), typeof(int) }, ParameterByRef = new bool[] { false, false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventFirmwareUpdate", Selector = "sbtEventFirmwareUpdate:", ParameterType = new Type[] { typeof(SMH.iOS.Zebra.FirmwareUpdateEvent) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventImage", Selector = "sbtEventImage:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(int) }, ParameterByRef = new bool[] { false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEventVideo", Selector = "sbtEventVideo:fromScanner:", ParameterType = new Type[] { typeof(NSData), typeof(int) }, ParameterByRef = new bool[] { false, false })]
    public interface IISbtSdkApiDelegate : INativeObject, IDisposable
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventScannerAppeared:")]
        [Preserve(Conditional = true)]
        void SbtEventScannerAppeared(SbtScannerInfo availableScanner);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventScannerDisappeared:")]
        [Preserve(Conditional = true)]
        void SbtEventScannerDisappeared(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventCommunicationSessionEstablished:")]
        [Preserve(Conditional = true)]
        void SbtEventCommunicationSessionEstablished(SbtScannerInfo activeScanner);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventCommunicationSessionTerminated:")]
        [Preserve(Conditional = true)]
        void SbtEventCommunicationSessionTerminated(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [Preserve(Conditional = true)]
        void SbtEventBarcode(string barcodeData, int barcodeType, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [Preserve(Conditional = true)]
        void SbtEventBarcodeData(NSData barcodeData, int barcodeType, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventFirmwareUpdate:")]
        [Preserve(Conditional = true)]
        void SbtEventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventImage:fromScanner:")]
        [Preserve(Conditional = true)]
        void SbtEventImage(NSData imageData, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEventVideo:fromScanner:")]
        [Preserve(Conditional = true)]
        void SbtEventVideo(NSData videoFrame, int scannerID);

    }

    internal sealed class ISbtSdkApiDelegateWrapper : BaseWrapper, IISbtSdkApiDelegate
    {
        [Preserve(Conditional = true)]
        public ISbtSdkApiDelegateWrapper(IntPtr handle, bool owns)
            : base(handle, owns)
        {
        }

        [Export("sbtEventScannerAppeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventScannerAppeared(SbtScannerInfo availableScanner)
        {
            if (availableScanner == null)
                throw new ArgumentNullException("availableScanner");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventScannerAppeared:"), availableScanner.Handle);
        }

        [Export("sbtEventScannerDisappeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventScannerDisappeared(int scannerID)
        {
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtEventScannerDisappeared:"), scannerID);
        }

        [Export("sbtEventCommunicationSessionEstablished:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventCommunicationSessionEstablished(SbtScannerInfo activeScanner)
        {
            if (activeScanner == null)
                throw new ArgumentNullException("activeScanner");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventCommunicationSessionEstablished:"), activeScanner.Handle);
        }

        [Export("sbtEventCommunicationSessionTerminated:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventCommunicationSessionTerminated(int scannerID)
        {
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtEventCommunicationSessionTerminated:"), scannerID);
        }

        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventBarcode(string barcodeData, int barcodeType, int scannerID)
        {
            if (barcodeData == null)
                throw new ArgumentNullException("barcodeData");
            var nsbarcodeData = NSString.CreateNative(barcodeData);

            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr_int_int(this.Handle, Selector.GetHandle("sbtEventBarcode:barcodeType:fromScanner:"), nsbarcodeData, barcodeType, scannerID);
            NSString.ReleaseNative(nsbarcodeData);

        }

        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventBarcodeData(NSData barcodeData, int barcodeType, int scannerID)
        {
            if (barcodeData == null)
                throw new ArgumentNullException("barcodeData");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr_int_int(this.Handle, Selector.GetHandle("sbtEventBarcodeData:barcodeType:fromScanner:"), barcodeData.Handle, barcodeType, scannerID);
        }

        [Export("sbtEventFirmwareUpdate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj)
        {
            if (fwUpdateEventObj == null)
                throw new ArgumentNullException("fwUpdateEventObj");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtEventFirmwareUpdate:"), fwUpdateEventObj.Handle);
        }

        [Export("sbtEventImage:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventImage(NSData imageData, int scannerID)
        {
            if (imageData == null)
                throw new ArgumentNullException("imageData");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr_int(this.Handle, Selector.GetHandle("sbtEventImage:fromScanner:"), imageData.Handle, scannerID);
        }

        [Export("sbtEventVideo:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SbtEventVideo(NSData videoFrame, int scannerID)
        {
            if (videoFrame == null)
                throw new ArgumentNullException("videoFrame");
            global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr_int(this.Handle, Selector.GetHandle("sbtEventVideo:fromScanner:"), videoFrame.Handle, scannerID);
        }

    }
}
namespace SMH.iOS.Zebra
{
    [Protocol()]
    [Register("ISbtSdkApiDelegate", false)]
    [Model]
    public unsafe abstract partial class ISbtSdkApiDelegate : NSObject, IISbtSdkApiDelegate
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        protected ISbtSdkApiDelegate() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = false;
            InitializeHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected ISbtSdkApiDelegate(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = false;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal ISbtSdkApiDelegate(IntPtr handle) : base(handle)
        {
            IsDirectBinding = false;
        }

        [Export("sbtEventBarcode:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventBarcode(string barcodeData, int barcodeType, int scannerID);
        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventBarcodeData(NSData barcodeData, int barcodeType, int scannerID);
        [Export("sbtEventCommunicationSessionEstablished:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventCommunicationSessionEstablished(SbtScannerInfo activeScanner);
        [Export("sbtEventCommunicationSessionTerminated:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventCommunicationSessionTerminated(int scannerID);
        [Export("sbtEventFirmwareUpdate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj);
        [Export("sbtEventImage:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventImage(NSData imageData, int scannerID);
        [Export("sbtEventScannerAppeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventScannerAppeared(SbtScannerInfo availableScanner);
        [Export("sbtEventScannerDisappeared:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventScannerDisappeared(int scannerID);
        [Export("sbtEventVideo:fromScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SbtEventVideo(NSData videoFrame, int scannerID);
    } /* class ISbtSdkApiDelegate */
}
