using System.Diagnostics;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        Double resultado = 0;
        string operacion = string.Empty;
        string primerNumero, segundoNumero;
        bool enterValue = false;
        public bool MinimizeBox { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana
            Application.Exit();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            //Minimizar Ventana
        }


        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0" || enterValue) textDisplay1.Text = string.Empty;
            {
                enterValue = false;
                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!textDisplay1.Text.Contains("."))
                        textDisplay1.Text = textDisplay1.Text + button.Text;
                }
                else textDisplay1.Text = textDisplay1.Text + button.Text;
            }
        }

        private void BtnOperaciones(object sender, EventArgs e)
        {
            if (resultado != 0) BtnEqual.PerformClick();
            else resultado = Double.Parse(textDisplay1.Text);

            Button button = (Button)sender;
            operacion = button.Text;
            enterValue = true;
            if (textDisplay1.Text != "0")
            {
                textDisplay2.Text = primerNumero = $"{resultado} {operacion}";
                textDisplay1.Text = string.Empty;
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            segundoNumero = textDisplay1.Text;
            textDisplay2.Text = $"{textDisplay2.Text} {textDisplay1.Text} =";
            if (textDisplay1.Text != string.Empty)
            {
                if (textDisplay1.Text == "0") textDisplay2.Text = string.Empty;
                switch (operacion)
                {
                    case "+":
                        textDisplay1.Text = (resultado + Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "-":
                        textDisplay1.Text = (resultado - Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "×":
                        textDisplay1.Text = (resultado * Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "∕":
                        textDisplay1.Text = (resultado / Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    default:
                        textDisplay2.Text = $"{textDisplay1.Text}=";
                        break;
                }

                resultado = Double.Parse(textDisplay1.Text);
                operacion = string.Empty;
            }
        }

        private void botonHistorial_Click(object sender, EventArgs e)
        {
            panelHistorial.Height = (panelHistorial.Height == 5) ? panelHistorial.Height = 345 : 5;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            textDisplay2.Text = string.Empty;
            resultado = 0;
        }

        private void botonLimpiarHistorial_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
            {
                RtBoxDisplayHistory.Text = " ";
            }
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text.Length > 0)
                textDisplay1.Text = textDisplay1.Text.Remove(textDisplay1.Text.Length - 1, 1);
            if (textDisplay1.Text == string.Empty) textDisplay1.Text = "0";

        }

        private void BtnOperacionesAvanzadas(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operacion = button.Text;
            switch (operacion)
            {
                case "√×":
                    textDisplay2.Text = $"√({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textDisplay1.Text)));
                    break;
                case "ˆ2":
                    textDisplay2.Text = $"({textDisplay1.Text})ˆ2";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) * Convert.ToDouble(textDisplay1.Text));
                    break;
                case "⅓":
                    textDisplay2.Text = $"({textDisplay1.Text})⅓";
                    textDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(textDisplay1.Text));
                    break;
                case "%":
                    textDisplay2.Text = $"%({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    textDisplay2.Text = $"%({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(textDisplay1.Text));
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{textDisplay2.Text} = {textDisplay1.Text}\n");
        }
    }
}
