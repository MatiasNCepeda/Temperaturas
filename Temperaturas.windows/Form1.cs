namespace Temperaturas.windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double celcius;
        double fahrenheit;
        double reaumur;
        int contador;
        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(celsiusText.Text, out celcius))
            {
                MessageBox.Show("Temperatura no valida");
                celsiusText.Clear();
            }
            else if (celcius < -50 || celcius > 50)
            {
                MessageBox.Show("Temperatura no valida");
                celsiusText.Clear();
            }
            else
            {
                reaumur = 0.8 * celcius;
                fahrenheit = 1.8 * celcius + 32;
                MessageBox.Show($"La temperatura en Fahrenheit es {fahrenheit} y la temperatura en reaumur es {reaumur}");
                contador = contador + 1;
                celsiusText.Clear();
                ContadorLabel.Text = contador.ToString();
            }
        }
    }
}