namespace LinkedIn.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
	}
    private void btnLogoutIngresar_Clicked(object sender, EventArgs e)
    {
         Navigation.PushAsync(new LoginView()); 
    }

    private void btnAboutIngresar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutView());
    }
}