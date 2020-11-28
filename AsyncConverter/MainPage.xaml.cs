using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncConverter.Services;
using AsyncConverter.ViewModels;
using Xamarin.Forms;

namespace AsyncConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // in real world this is done with IoC ... 
            BindingContext = new MainPageViewModel(new ProductsService());
        }
    }
}
