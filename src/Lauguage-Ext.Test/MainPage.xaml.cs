using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Lauguage_Ext.Test.Model;
using Xamarin.Forms;
using static LanguageExt.Prelude;


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
            // This crashes on every version of Language-Ext later than 3.1.24
            var objA = new ObjectA<object>(new object());
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            // this crashes on every version of Language-Ext later than 3.1.24
            var testFunc = fun((int x) => Task.Delay(TimeSpan.FromSeconds(x)));

            // The code never gets to this.
            testFunc(5).Wait();
        }
    }
}
