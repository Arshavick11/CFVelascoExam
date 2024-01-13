namespace CFVelascoExam;

public partial class Resumen : ContentPage
{
    public Resumen(String[] persona)
    {
        InitializeComponent();
        nombre.Text = persona[0];
        apellido.Text = persona[1];
        edad.Text = persona[2];
        fecha.Text = persona[3];
        ciudad.Text = persona[4];
        pais.Text = persona[5];
        monoInicial.Text = persona[6];
        mensual.Text = persona[7];
        total.Text = persona[8];


    }

    private void Button_Cerrar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}