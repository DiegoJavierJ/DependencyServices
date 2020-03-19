using DependencyServiceApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServiceApp.Model
{
    public class OrientationState : INotifyPropertyChanged
    {
        //DeviceOrientation orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
        //private string orientationText;
        //public string OrientationText 
        //{
        //    get
        //    {
        //        return orientationText;
        //    }
        //    set
        //    {
                
        //        orientationText = orientation.ToString();
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
