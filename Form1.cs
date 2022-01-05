namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void operacao_click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtV1.Text);
            valor2 = double.Parse(txtV2.Text);
            string tipo_operacao = (sender as Button).Text;
            lblResultado.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(),
                tipo_operacao, valor2.ToString(), operacao(tipo_operacao));
        }

        private string operacao(string tipo)
        {
            double resultado = 0;


            switch (tipo)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    break;

                case "x":
                    resultado = valor1 * valor2;
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    break;
            }


            return resultado.ToString();
        }
    }
}