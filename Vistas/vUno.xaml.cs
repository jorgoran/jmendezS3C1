namespace jmendezS3C1.Vistas;

public partial class vUno : ContentPage
{
    string usuarioGlobal = "";
    string claveGlobal = "";
    public vUno()
	{
		InitializeComponent();

	}
    public vUno(string usuarioRegistro, string claveRegistro)
    {
        InitializeComponent();
        usuarioGlobal = usuarioRegistro;
        claveGlobal = claveRegistro;


    }

    private void btnAbrir_clicked(object sender, EventArgs e)
    {
		try
        {
			string usuario = txtUsuario.Text;
			string clave = txtClave.Text;
                if (usuario == usuarioGlobal || clave == claveGlobal)
                {
                Navigation.PushAsync(new vDos(usuario, clave));
                }
            else
                {
                DisplayAlert("Error", "Usuario o clave incorrectos", "Cerrar");
                return;
                }
            
            
        }
		catch (Exception ex)
        {
			Console.WriteLine(ex.Message);
        }
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new vTres());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}