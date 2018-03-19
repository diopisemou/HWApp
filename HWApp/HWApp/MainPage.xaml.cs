using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HWApp
{
	public partial class MainPage : ContentPage
	{
	    private double _appSliderValue;

        public MainPage()
		{
		    BindingContext = this;
            InitializeComponent();
            AppSliderValue = AppSlider.Value;
		    date.Text = "Date : " + DateTime.Now.ToShortDateString();
		    time.Text = "Time : " + DateTime.Now.ToLongTimeString();

        }

	    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
	    {
	        if (EqualityComparer<T>.Default.Equals(backingStore, value))
	            return false;

	        backingStore = value;
	        onChanged?.Invoke();
	        OnPropertyChanged(propertyName);
	        return true;
	    }

	    public double AppSliderValue
	    {
	        get { return _appSliderValue; }
	        set { SetProperty(ref _appSliderValue, value); }
        }

	    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
	    {
	        date.Text = "Date : " + e.NewDate.ToShortDateString();
	        time.Text = "Time : " + e.NewDate.ToLongTimeString();
	    }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        //AppSliderValue = AppSlider.Value;
	    }

	    private void AppSwitch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        //AppSliderValue = AppSwitch.IsToggled ? 100 : 0;
	    }


	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        string url = siteweb.Text ?? "http://www.xamarin.com/";
            
            WebView nextView = new WebView(url);
	        Navigation.PushAsync(nextView);

	    }

	    private void Button_OnClicked2(object sender, EventArgs e)
	    {
	        
	        PickerView nextView = new PickerView();
	        Navigation.PushAsync(nextView);

	    }
    }
}
