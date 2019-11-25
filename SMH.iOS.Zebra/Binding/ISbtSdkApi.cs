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

namespace SMH.iOS.Zebra {
	[Protocol (Name = "ISbtSdkApi", WrapperType = typeof (ISbtSdkApiWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtSetDelegate", Selector = "sbtSetDelegate:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (SMH.iOS.Zebra.ISbtSdkApiDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtGetVersion", Selector = "sbtGetVersion", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtSetOperationalMode", Selector = "sbtSetOperationalMode:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtSubsribeForEvents", Selector = "sbtSubsribeForEvents:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtUnsubsribeForEvents", Selector = "sbtUnsubsribeForEvents:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtGetAvailableScannersList", Selector = "sbtGetAvailableScannersList:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (NSMutableArray) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtGetActiveScannersList", Selector = "sbtGetActiveScannersList:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (NSMutableArray) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEstablishCommunicationSession", Selector = "sbtEstablishCommunicationSession:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtTerminateCommunicationSession", Selector = "sbtTerminateCommunicationSession:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEnableAvailableScannersDetection", Selector = "sbtEnableAvailableScannersDetection:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtEnableAutomaticSessionReestablishment", Selector = "sbtEnableAutomaticSessionReestablishment:forScanner:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (bool), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtExecuteCommand", Selector = "sbtExecuteCommand:aInXML:aOutXML:forScanner:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int), typeof (string), typeof (NSMutableString), typeof (int) }, ParameterByRef = new bool [] { false, false, true, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtLedControl", Selector = "sbtLedControl:aLedCode:forScanner:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (bool), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtBeepControl", Selector = "sbtBeepControl:forScanner:", ReturnType = typeof (SMH.iOS.Zebra.SbtResult), ParameterType = new Type [] { typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtSetBTAddress", Selector = "sbtSetBTAddress:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtGetPairingBarcode", Selector = "sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (SMH.iOS.Zebra.BarcodeType), typeof (SMH.iOS.Zebra.StcComProtocol), typeof (SMH.iOS.Zebra.SetdefaultStatus), typeof (string), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public interface IISbtSdkApi : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtSetDelegate:")]
		[Preserve (Conditional = true)]
		SbtResult SbtSetDelegate (ISbtSdkApiDelegate @delegate);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtGetVersion")]
		[Preserve (Conditional = true)]
		string SbtGetVersion ();
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtSetOperationalMode:")]
		[Preserve (Conditional = true)]
		SbtResult SbtSetOperationalMode (int operationalMode);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtSubsribeForEvents:")]
		[Preserve (Conditional = true)]
		SbtResult SbtSubsribeForEvents (int sdkEventsMask);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtUnsubsribeForEvents:")]
		[Preserve (Conditional = true)]
		SbtResult SbtUnsubsribeForEvents (int sdkEventsMask);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtGetAvailableScannersList:")]
		[Preserve (Conditional = true)]
		SbtResult SbtGetAvailableScannersList (ref NSMutableArray availableScannersList);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtGetActiveScannersList:")]
		[Preserve (Conditional = true)]
		SbtResult SbtGetActiveScannersList (ref NSMutableArray activeScannersList);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtEstablishCommunicationSession:")]
		[Preserve (Conditional = true)]
		SbtResult SbtEstablishCommunicationSession (int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtTerminateCommunicationSession:")]
		[Preserve (Conditional = true)]
		SbtResult SbtTerminateCommunicationSession (int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtEnableAvailableScannersDetection:")]
		[Preserve (Conditional = true)]
		SbtResult SbtEnableAvailableScannersDetection (bool enable);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtEnableAutomaticSessionReestablishment:forScanner:")]
		[Preserve (Conditional = true)]
		SbtResult SbtEnableAutomaticSessionReestablishment (bool enable, int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
		[Preserve (Conditional = true)]
		SbtResult SbtExecuteCommand (int opCode, string inXML, ref NSMutableString outXML, int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtLedControl:aLedCode:forScanner:")]
		[Preserve (Conditional = true)]
		SbtResult SbtLedControl (bool enable, int ledCode, int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtBeepControl:forScanner:")]
		[Preserve (Conditional = true)]
		SbtResult SbtBeepControl (int beepCode, int scannerID);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtSetBTAddress:")]
		[Preserve (Conditional = true)]
		void SbtSetBTAddress (string btAdd);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIImage SbtGetPairingBarcode (BarcodeType barcodeType, StcComProtocol comProtocol, SetdefaultStatus setDefaultsStatus, string btAddress, CGRect imageFrame);
		
	}
	
	internal sealed class ISbtSdkApiWrapper : BaseWrapper, IISbtSdkApi {
		[Preserve (Conditional = true)]
		public ISbtSdkApiWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("sbtSetDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtSetDelegate (ISbtSdkApiDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sbtSetDelegate:"), @delegate.Handle);
		}
		
		[Export ("sbtGetVersion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string SbtGetVersion ()
		{
			return NSString.FromHandle (global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sbtGetVersion")));
		}
		
		[Export ("sbtSetOperationalMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtSetOperationalMode (int operationalMode)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sbtSetOperationalMode:"), operationalMode);
		}
		
		[Export ("sbtSubsribeForEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtSubsribeForEvents (int sdkEventsMask)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sbtSubsribeForEvents:"), sdkEventsMask);
		}
		
		[Export ("sbtUnsubsribeForEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtUnsubsribeForEvents (int sdkEventsMask)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sbtUnsubsribeForEvents:"), sdkEventsMask);
		}
		
		[Export ("sbtGetAvailableScannersList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtGetAvailableScannersList (ref NSMutableArray availableScannersList)
		{
			IntPtr availableScannersListValue = availableScannersList.Handle;
			
			SbtResult ret;
			ret = (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("sbtGetAvailableScannersList:"), ref availableScannersListValue);
			availableScannersList = Runtime.GetNSObject<NSMutableArray> (availableScannersListValue);
			
			return ret;
		}
		
		[Export ("sbtGetActiveScannersList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtGetActiveScannersList (ref NSMutableArray activeScannersList)
		{
			IntPtr activeScannersListValue = activeScannersList.Handle;
			
			SbtResult ret;
			ret = (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("sbtGetActiveScannersList:"), ref activeScannersListValue);
			activeScannersList = Runtime.GetNSObject<NSMutableArray> (activeScannersListValue);
			
			return ret;
		}
		
		[Export ("sbtEstablishCommunicationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtEstablishCommunicationSession (int scannerID)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sbtEstablishCommunicationSession:"), scannerID);
		}
		
		[Export ("sbtTerminateCommunicationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtTerminateCommunicationSession (int scannerID)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("sbtTerminateCommunicationSession:"), scannerID);
		}
		
		[Export ("sbtEnableAvailableScannersDetection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtEnableAvailableScannersDetection (bool enable)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_bool (this.Handle, Selector.GetHandle ("sbtEnableAvailableScannersDetection:"), enable);
		}
		
		[Export ("sbtEnableAutomaticSessionReestablishment:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtEnableAutomaticSessionReestablishment (bool enable, int scannerID)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_bool_int (this.Handle, Selector.GetHandle ("sbtEnableAutomaticSessionReestablishment:forScanner:"), enable, scannerID);
		}
		
		[Export ("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtExecuteCommand (int opCode, string inXML, ref NSMutableString outXML, int scannerID)
		{
			if (inXML == null)
				throw new ArgumentNullException ("inXML");
			IntPtr outXMLValue = outXML.Handle;
			
			var nsinXML = NSString.CreateNative (inXML);
			
			SbtResult ret;
			ret = (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int_IntPtr_ref_IntPtr_int (this.Handle, Selector.GetHandle ("sbtExecuteCommand:aInXML:aOutXML:forScanner:"), opCode, nsinXML, ref outXMLValue, scannerID);
			NSString.ReleaseNative (nsinXML);
			
			outXML = Runtime.GetNSObject<NSMutableString> (outXMLValue);
			
			return ret;
		}
		
		[Export ("sbtLedControl:aLedCode:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtLedControl (bool enable, int ledCode, int scannerID)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_bool_int_int (this.Handle, Selector.GetHandle ("sbtLedControl:aLedCode:forScanner:"), enable, ledCode, scannerID);
		}
		
		[Export ("sbtBeepControl:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SbtResult SbtBeepControl (int beepCode, int scannerID)
		{
			return (SbtResult) global::ApiDefinition.ZebraMessaging.UInt32_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("sbtBeepControl:forScanner:"), beepCode, scannerID);
		}
		
		[Export ("sbtSetBTAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SbtSetBTAddress (string btAdd)
		{
			if (btAdd == null)
				throw new ArgumentNullException ("btAdd");
			var nsbtAdd = NSString.CreateNative (btAdd);
			
			global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sbtSetBTAddress:"), nsbtAdd);
			NSString.ReleaseNative (nsbtAdd);
			
		}
		
		[Export ("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIImage SbtGetPairingBarcode (BarcodeType barcodeType, StcComProtocol comProtocol, SetdefaultStatus setDefaultsStatus, string btAddress, CGRect imageFrame)
		{
			if (btAddress == null)
				throw new ArgumentNullException ("btAddress");
			var nsbtAddress = NSString.CreateNative (btAddress);
			
			global::UIKit.UIImage ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend_UInt32_UInt32_UInt32_IntPtr_CGRect (this.Handle, Selector.GetHandle ("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:"), (UInt32)barcodeType, (UInt32)comProtocol, (UInt32)setDefaultsStatus, nsbtAddress, imageFrame));
			NSString.ReleaseNative (nsbtAddress);
			
			return ret;
		}
		
	}
}
namespace SMH.iOS.Zebra {
	[Protocol()]
	[Register("ISbtSdkApi", false)]
	[Model]
	public unsafe abstract partial class ISbtSdkApi : NSObject, IISbtSdkApi {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISbtSdkApi () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISbtSdkApi (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISbtSdkApi (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("sbtBeepControl:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtBeepControl (int beepCode, int scannerID);
		[Export ("sbtEnableAutomaticSessionReestablishment:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtEnableAutomaticSessionReestablishment (bool enable, int scannerID);
		[Export ("sbtEnableAvailableScannersDetection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtEnableAvailableScannersDetection (bool enable);
		[Export ("sbtEstablishCommunicationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtEstablishCommunicationSession (int scannerID);
		[Export ("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtExecuteCommand (int opCode, string inXML, ref NSMutableString outXML, int scannerID);
		[Export ("sbtGetActiveScannersList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtGetActiveScannersList (ref NSMutableArray activeScannersList);
		[Export ("sbtGetAvailableScannersList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtGetAvailableScannersList (ref NSMutableArray availableScannersList);
		[Export ("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIImage SbtGetPairingBarcode (BarcodeType barcodeType, StcComProtocol comProtocol, SetdefaultStatus setDefaultsStatus, string btAddress, CGRect imageFrame);
		[Export ("sbtGetVersion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string SbtGetVersion ();
		[Export ("sbtLedControl:aLedCode:forScanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtLedControl (bool enable, int ledCode, int scannerID);
		[Export ("sbtSetBTAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void SbtSetBTAddress (string btAdd);
		[Export ("sbtSetDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtSetDelegate (ISbtSdkApiDelegate @delegate);
		[Export ("sbtSetOperationalMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtSetOperationalMode (int operationalMode);
		[Export ("sbtSubsribeForEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtSubsribeForEvents (int sdkEventsMask);
		[Export ("sbtTerminateCommunicationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtTerminateCommunicationSession (int scannerID);
		[Export ("sbtUnsubsribeForEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract SbtResult SbtUnsubsribeForEvents (int sdkEventsMask);
	} /* class ISbtSdkApi */
}
