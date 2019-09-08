using System;
using System.ComponentModel;
using Lauguage_Ext.Test.Model;
using Xamarin.Forms;

namespace Lauguage_Ext.Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void Test_OnClicked(object sender, EventArgs e)
        {
            // This makes the app crash most of the time. Why?
            var objA = new ObjectA<object>(new object());
        }
    }
}
