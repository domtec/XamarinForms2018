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
		public Master ()
		{
			InitializeComponent ();
		}
        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new Controles.ActivityIndicatorPage();
            IsPresented = false;
        }

        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.ProgressBarPage();
            IsPresented = false;
        }

        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new Controles.BoxViewPage();
            IsPresented = false;
        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new Controles.LabelPage();
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new Controles.ButtonPage();
            IsPresented = false;
        }
        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.EntryEditorPage();
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.DatePickerPage();
            IsPresented = false;
        }

        private void GoTimePickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.TimePickerPage();
            IsPresented = false;
        }

        private void GoPickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.PickerPage();
            IsPresented = false;
        }

        private void GoSearchBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.SearchBarPage();
            IsPresented = false;
        }

        private void GoSliderStepperPage(object sender, EventArgs args)
        {
            Detail = new Controles.SliderStepperPage();
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs args)
        {
            Detail = new Controles.SwitchPage();
            IsPresented = false;
        }
    }
}