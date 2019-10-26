using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void goActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }
        private void goProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.ProgressBarPage();
        }
        private void goBoxViewPage(object sender, EventArgs args)
        {
            Detail = new Controles.BoxViewPage();
        }
        private void goLabelPage (object sender, EventArgs args)
        {
            Detail = new Controles.LabelPage();
        }
        private void goButtonPage (object sender, EventArgs args)
        {
            Detail = new Controles.ButtonPage();
        }
        private void goEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.EntryEditorPage();
        }
        private void goDatePickerEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.DatePickerPage();
        }
        private void goTimePickerEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.TimePickerPage();
        }
        private void goPickerEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.PickerPage();
        }
        private void goSearchBarEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.SearchBarPage();
        }
        private void goSliderStepperPage(object sender, EventArgs args)
        {
            Detail = new Controles.SliderStepperPage();
        }
        private void goSwitchPage(object sender, EventArgs args)
        {
            Detail = new Controles.SwitchPage();
        }        
    }
}