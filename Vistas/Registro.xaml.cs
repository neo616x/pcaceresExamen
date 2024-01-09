namespace pcaceresExamen.Vistas;

    public partial class Registro : ContentPage
    {
        double costo = 1500;
        double total;

        public Registro(string usuario)
        {
            InitializeComponent();

            // Llamar usuario conectado de Login
            lblUsuario.Text = usuario;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenar en variables, lo que el usuario ingresa en las cajas de texto.
                double porcentaje = costo * 0.04;
                double monto = Convert.ToDouble(txtMontoInicial.Text);

                if (monto >= 1 && monto <= 1500)
                {
                    //Operación
                    double cuotas = ((costo - monto) / 4) + porcentaje;
                    total = monto + (cuotas * 4);

                    //Visualizar el resultado en pantalla
                    txtPagoMensual.Text = cuotas.ToString("c2");
                }
                else
                {
                    await DisplayAlert("Datos incorrectos", "El monto inicial debe ser entre 1 y 1500", "OK");
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }
        }

      
    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Realizado por: ", "Pablo Caceres - 8vo A", "OK");
    }
}
