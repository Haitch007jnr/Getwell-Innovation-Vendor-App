namespace Getwell_Innovation_Vendor_App;

public partial class Employee : ContentPage
{
    public Employee()
    {
        InitializeComponent();
    }
    WebView webvView = new WebView
    {
        Source = "https://getwellweb.com/admin/login/store-employee"
    };
}
