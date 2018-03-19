using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HWApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebView : ContentPage
	{
	    public string browserurl;
		
	    public WebView(string url = null)
	    {
	        browserurl = url ?? "http://www.xamarin.com/";
            InitializeComponent();
	        MyBrowser.Source = browserurl;
	    }
    }
}