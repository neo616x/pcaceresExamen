namespace pcaceresExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        // Vectores de usuarios y contraseñas
        string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] contrasenas = { "uisrael2024", "parcial1", "2024" };

        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        // Verificar las credenciales
        bool credencialesValidas = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contrasena == contrasenas[i])
            {
                credencialesValidas = true;
                break;
            }
        }
        if (credencialesValidas == true)
        {
            Navigation.PushAsync(new Registro(usuario));
            MostrarMensajeBienvenida(usuario);
        }
        else
        {
            DisplayAlert("Alerta", "Crendenciales incorrectos", "Cancelar");
        }

    }

    private void MostrarMensajeBienvenida(string usuario)
    {
        DisplayAlert("UISRAEL", $"¡Bienvenido, {usuario}!", "OK");

    }


    

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Realizado por: ", "Pablo Caceres - 8vo A", "OK");
    }
}

