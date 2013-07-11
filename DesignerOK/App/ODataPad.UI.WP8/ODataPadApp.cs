using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace ODataPad.UI.WP8
{
    public class ODataPadApp : MvxApplication
    {
        public HomeViewModel HomeViewModel { get; private set; }
    }
}