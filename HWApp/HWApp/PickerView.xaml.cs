using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HWApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerView : ContentPage
	{
		

        private List<Gallery> DogImages;
        private List<Gallery> CatImages;
	    private List<Gallery> BirdImages;

        private List<Gallery> ListImages;

        public PickerView()
        {
            InitializeComponent();

            BindingContext = this;
            DogImages = new List<Gallery>
            {
                new Gallery
                {
                    category = "Dogs",
                    source = ImageSource.FromResource("HWApp.Images.dog1.jpg")
                },
                new Gallery
                {
                    category = "Dogs",
                    source = ImageSource.FromResource("HWApp.Images.dog2.jpg")
                },
                new Gallery
                {
                    category = "Dogs",
                    source = ImageSource.FromResource("HWApp.Images.dog3.jpg")
                }
            };
            CatImages = new List<Gallery>
            {
                new Gallery
                {
                    category = "Cats",
                    source = ImageSource.FromResource("HWApp.Images.cat1.jpg")
                },
                new Gallery
                {
                    category = "Cats",
                    source = ImageSource.FromResource("HWApp.Images.cat2.jpg")
                },
                new Gallery
                {
                    category = "Cats",
                    source = ImageSource.FromResource("HWApp.Images.cat3.jpg")
                }
            };
            BirdImages = new List<Gallery>
            {
                new Gallery
                {
                    category = "Birds",
                    source = ImageSource.FromResource("HWApp.Images.bird1.jpg")
                },
                new Gallery
                {
                    category = "Birds",
                    source = ImageSource.FromResource("HWApp.Images.bird2.jpg")
                },
                new Gallery
                {
                    category = "Birds",
                    source = ImageSource.FromResource("HWApp.Images.bird3.jpg")
                }
            };
            ListImages = new List<Gallery>();
            foreach (var VARIABLE in DogImages)
            {
                ListImages.Add(VARIABLE);

            }
            foreach (var VARIABLE in CatImages)
            {
                ListImages.Add(VARIABLE);

            }
            foreach (var VARIABLE in BirdImages)
            {
                ListImages.Add(VARIABLE);

            }

            MainCarouselView.ItemsSource = ListImages;

        }




        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (Tab1Checked)
            {
                foreach (var VARIABLE in CatImages)
                {
                    ListImages.Add(VARIABLE);

                }
            }

            if (Tab2Checked)
            {
                foreach (var VARIABLE in DogImages)
                {
                    ListImages.Add(VARIABLE);

                }
            }

            if (Tab3Checked)
            {
                foreach (var VARIABLE in BirdImages)
                {
                    ListImages.Add(VARIABLE);

                }

            }
            MainCarouselView.ItemsSource = ListImages;
        }



      

        bool tab1Checked = true;
        public bool Tab1Checked
        {
            get { return tab1Checked; }
            set => SetProperty(ref tab1Checked, value);
        }


        bool tab2Checked = true;
        public bool Tab2Checked
        {
            get { return tab2Checked; }
            set => SetProperty(ref tab2Checked, value);
        }


        bool tab3Checked = true;
        public bool Tab3Checked
        {
            get { return tab3Checked; }
            set => SetProperty(ref tab3Checked, value);
        }

        public ICommand TabTappedCommand
        {
            get
            {
                return new Command((e) =>
                {
                    if (int.Parse(e.ToString()) == 1)
                    {
                        if (Tab1Checked)
                        {
                            Tab1Checked = false;
                        }
                        else if (!Tab1Checked)

                        {
                            Tab1Checked = true;
                        }
                    }
                    if (int.Parse(e.ToString()) == 2)
                    {
                        if (Tab2Checked)
                        {
                            Tab2Checked = false;
                        }
                        else if (!Tab2Checked)
                        {
                            Tab2Checked = true;
                        }

                    }
                    if (int.Parse(e.ToString()) == 3)
                    {
                        if (Tab3Checked)
                        {
                            Tab3Checked = false;
                        }
                        else if (!Tab3Checked)
                        {
                            Tab3Checked = true;
                        }

                    }
                });
            }

            set => new Command((e) =>
                {
                    if (int.Parse(e.ToString()) == 1)
                    {
                        if (Tab1Checked)
                        {
                            Tab1Checked = false;
                        }
                        else if (!Tab1Checked)

                        {
                            Tab1Checked = true;
                        }
                    }
                    if (int.Parse(e.ToString()) == 2)
                    {
                        if (Tab2Checked)
                        {
                            Tab2Checked = false;
                        }
                        else if (!Tab2Checked)
                        {
                            Tab2Checked = true;
                        }

                    }
                    if (int.Parse(e.ToString()) == 3)
                    {
                        if (Tab3Checked)
                        {
                            Tab3Checked = false;
                        }
                        else if (!Tab3Checked)
                        {
                            Tab3Checked = true;
                        }

                    }
                });


        }

        class Gallery
	    {
	        public string category { get; set; }
	        public ImageSource source { get; set; }
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
    }
}