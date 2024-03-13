
namespace ControlAdmin_IFOR;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnNuevaCuenta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }



    private void btnOlvidoPassw_Clicked(object sender, EventArgs e)
    {

    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {

    }


}