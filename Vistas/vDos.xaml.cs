namespace jmendezS3C1.Vistas;

public partial class vDos : ContentPage
{
	public vDos(string dato1, string dato2)
	{
		InitializeComponent();
		lbldato1.Text = "Eldatp uno es " + dato1;
        lbldato2.Text = "Eldatp dos es " + dato2;
    }

    private void btnAbrir1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new vUno());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}