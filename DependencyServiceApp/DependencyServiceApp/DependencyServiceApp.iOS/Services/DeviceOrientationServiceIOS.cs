using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyServiceApp.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;
[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceApp.iOS.Services.DeviceOrientationServiceIOS))]
namespace DependencyServiceApp.iOS.Services
{
    public class DeviceOrientationServiceIOS : IDeviceOrientation
    {
            public DeviceOrientation GetOrientation()
            {
                UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

                bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                    orientation == UIInterfaceOrientation.PortraitUpsideDown;
                return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
            }
    }
}