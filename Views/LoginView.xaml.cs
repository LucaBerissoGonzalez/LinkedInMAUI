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
            //DisplayAlert("�xito", "inicio de sesion exitoso", "OK");
        }
        else
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            DisplayAlert("Atenci�n", "las credenciales ingresadas no son v�lidas", "OK");
        }
    }


}