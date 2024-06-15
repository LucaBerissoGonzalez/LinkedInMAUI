namespace LinkedIn.Views;

public partial class LoginView : ContentPage
{

	public LoginView()
	{
		InitializeComponent();
    }

    private void btnLoginIngresar_Clicked(object sender, EventArgs e)
    {
        if (username.Text == "ites" && password.Text == "1234")
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            Navigation.PushAsync(new PrincipalView());
            //DisplayAlert("Éxito", "inicio de sesion exitoso", "OK");
        }
        else
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            DisplayAlert("Atención", "las credenciales ingresadas no son válidas", "OK");
        }
    }


}