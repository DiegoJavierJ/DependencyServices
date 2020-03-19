using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace DependencyServiceApp.Services
{
    public interface IDeviceOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
