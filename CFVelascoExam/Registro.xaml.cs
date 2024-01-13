namespace CFVelascoExam;

public partial class Registro : ContentPage
{

    public Registro(String usuario)
    {
        InitializeComponent();


        titulo.Text = usuario;
    }

    private void BotonCalcular(object sender, EventArgs e)
    {
        string monto = Monto.Text;
        float calculo = (float)(((1500 - float.Parse(monto)) / 4) + (1500 * 0.04));
        mensual.Text = calculo.ToString();

    }

    private void resumen_Clicked(object sender, EventArgs e)
    {

        DateTime fechaSeleccionada = fecha.Date;
        string dia = fechaSeleccionada.ToString();
        string ciudadSeleccionada = ciudad.SelectedItem.ToString();
        string paisSeleccionado = pais.SelectedItem.ToString();

        string monto = Monto.Text;
        float calculo = (float)(((1500 - float.Parse(monto)) / 4) + (1500 * 0.4));
        String mensual = calculo.ToString();
        double total = calculo * 4;
        String totalEnviar = total.ToString();
        String[] persona = { nombre.Text, apellido.Text, edad.Text, dia, ciudadSeleccionada, paisSeleccionado, Monto.Text, mensual, totalEnviar };
        Navigation.PushAsync(new Resumen(persona));

    }
}