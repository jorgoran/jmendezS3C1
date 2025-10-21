namespace jmendezS3C1.Vistas;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuario = txtUsuario3.Text;
            string clave = txtClave3.Text;
            Navigation.PushAsync(new vUno(usuario, clave));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}