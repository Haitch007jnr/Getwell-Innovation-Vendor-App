namespace Getwell_Innovation_Vendor_App
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        WebView webvView = new WebView
        {
            Source = "https://getwellweb.com/admin/login/store"
        };

    }

    }
