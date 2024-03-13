namespace ControlAdmin_IFOR;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private void btnNuevaCuenta_Clicked(object sender, EventArgs e)
    {

    }

    private void btnOlvidoPassw_Clicked(object sender, EventArgs e)
    {

    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {

    }

    private async void btnAceptar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}