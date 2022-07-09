namespace proyectoFinalCalculadoraAcuñaVictor
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operado = Operacion.NoDefinida;
        bool unNumeroLeido = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void leerNumero(string numero)
        {
            unNumeroLeido = true;
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }

        private double operacion()
        {
            double resultado = 0;
            switch (operado)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;

                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;

                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        lblHistorial.Text = " No se puede dividir en 0 .";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;
        }
       private void btn0_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }
        private void ObtenerValor(String operado)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operado;
            cajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operado = Operacion.Suma;
            ObtenerValor("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operado = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operado = Operacion.Multiplicacion;
            ObtenerValor("X");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operado = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = operacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtResultado;
                }
            }
            else
            {
                cajaResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Contains('.'))
            {
                return;
            }
            cajaResultado.Text += ".";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";
        }
    }
}