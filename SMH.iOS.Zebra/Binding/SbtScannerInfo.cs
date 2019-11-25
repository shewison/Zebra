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
    [Register("SbtScannerInfo", true)]
    public unsafe partial class SbtScannerInfo : NSObject
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        static readonly IntPtr class_ptr = Class.GetHandle("SbtScannerInfo");

        public override IntPtr ClassHandle { get { return class_ptr; } }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        public SbtScannerInfo() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinition.ZebraMessaging.this_assembly;
            if (IsDirectBinding)
            {
                InitializeHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
            else
            {
                InitializeHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected SbtScannerInfo(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinition.ZebraMessaging.this_assembly;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal SbtScannerInfo(IntPtr handle) : base(handle)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinition.ZebraMessaging.this_assembly;
        }

        [Export("dealloc")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void Dealloc()
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend(this.Handle, Selector.GetHandle("dealloc"));
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("dealloc"));
            }
        }

        [Export("setActive:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetActive(bool active)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setActive:"), active);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setActive:"), active);
            }
        }

        [Export("setAutoCommunicationSessionReestablishment:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetAutoCommunicationSessionReestablishment(bool enable)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setAutoCommunicationSessionReestablishment:"), enable);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setAutoCommunicationSessionReestablishment:"), enable);
            }
        }

        [Export("setAvailable:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetAvailable(bool available)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setAvailable:"), available);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setAvailable:"), available);
            }
        }

        [Export("setConnectionType:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetConnectionType(int connectionType)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setConnectionType:"), connectionType);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setConnectionType:"), connectionType);
            }
        }

        [Export("setScannerID:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerID(int scannerID)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setScannerID:"), scannerID);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setScannerID:"), scannerID);
            }
        }

        [Export("setScannerModel:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerModel(int scannerModel)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setScannerModel:"), scannerModel);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setScannerModel:"), scannerModel);
            }
        }

        [Export("setScannerName:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerName(string scannerName)
        {
            if (scannerName == null)
                throw new ArgumentNullException("scannerName");
            var nsscannerName = NSString.CreateNative(scannerName);

            if (IsDirectBinding)
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setScannerName:"), nsscannerName);
            }
            else
            {
                global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setScannerName:"), nsscannerName);
            }
            NSString.ReleaseNative(nsscannerName);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool AutoCommunicationSessionReestablishment
        {
            [Export("getAutoCommunicationSessionReestablishment")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("getAutoCommunicationSessionReestablishment"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getAutoCommunicationSessionReestablishment"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int ConnectionType
        {
            [Export("getConnectionType")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("getConnectionType"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getConnectionType"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string FirmwareVersion
        {
            [Export("firmwareVersion", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("firmwareVersion")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("firmwareVersion")));
                }
            }

            [Export("setFirmwareVersion:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setFirmwareVersion:"), nsvalue);
                }
                else
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setFirmwareVersion:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool IsActive
        {
            [Export("isActive")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("isActive"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("isActive"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool IsAvailable
        {
            [Export("isAvailable")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("isAvailable"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("isAvailable"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string MFD
        {
            [Export("mFD", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("mFD")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("mFD")));
                }
            }

            [Export("setMFD:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setMFD:"), nsvalue);
                }
                else
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setMFD:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int ScannerID
        {
            [Export("getScannerID")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("getScannerID"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerID"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int ScannerModel
        {
            [Export("getScannerModel")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("getScannerModel"));
                }
                else
                {
                    return global::ApiDefinition.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerModel"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string ScannerModelString
        {
            [Export("scannerModelString", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("scannerModelString")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("scannerModelString")));
                }
            }

            [Export("setScannerModelString:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setScannerModelString:"), nsvalue);
                }
                else
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setScannerModelString:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string ScannerName
        {
            [Export("getScannerName")]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("getScannerName")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerName")));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string SerialNo
        {
            [Export("serialNo", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("serialNo")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinition.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("serialNo")));
                }
            }

            [Export("setSerialNo:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setSerialNo:"), nsvalue);
                }
                else
                {
                    global::ApiDefinition.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setSerialNo:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

    } /* class SbtScannerInfo */
}
