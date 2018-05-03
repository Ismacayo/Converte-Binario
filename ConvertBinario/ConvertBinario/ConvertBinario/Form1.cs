using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConvertBinario
{
    public partial class ConvertBinario : Form
    {

        private double controleDouble;
        private string controleString;
        private double num1;
        private double num2;

        public ConvertBinario()
        {
            InitializeComponent();

            EscolhaCalc.Items.Add("Decimal");
            EscolhaCalc.Items.Add("Binário");
            EscolhaCalc.Items.Add("Octal");
            EscolhaCalc.Items.Add("HexaDecimal");
            
        }

        void ZerarText()
        {
            Decimal.Text = "";
            Binario.Text = "";
            Octal.Text = "";
            HexaDecimal.Text = "";
        }

        void Calculo(char ope)
        {
            if (EscolhaCalc.SelectedIndex == 0) // Decimal
            {
                num1 = Convert.ToDouble(Num1.Text);
                num2 = Convert.ToDouble(Num1.Text);

                if (ope == '+') Resultado.Text = Convert.ToString(Calculos.Soma(num1, num2));
                else if (ope == '-') Resultado.Text = Convert.ToString(Calculos.SubTrair(num1, num2));
                else if (ope == '*') Resultado.Text = Convert.ToString(Calculos.Multiplicar(num1, num2));
                else if (ope == '/') Resultado.Text = Convert.ToString(Calculos.Dividir(num1, num2));
            }

            else if (EscolhaCalc.SelectedIndex == 1) // Binario
            {
                num1 = Conversor.FromBin(Convert.ToString(Num1.Text));
                num2 = Conversor.FromBin(Convert.ToString(Num2.Text));

                if (ope == '+')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Soma(num1, num2)), 2);
                }
                else if (ope == '-')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.SubTrair(num1, num2)), 2);
                }
                else if (ope == '*')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Multiplicar(num1, num2)), 2);
                }
                else if (ope == '/')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Dividir(num1, num2)), 2);
                }
            }

            else if (EscolhaCalc.SelectedIndex == 2) // Octal
            {
                num1 = Conversor.FromOct(Convert.ToString(Num1.Text));
                num2 = Conversor.FromOct(Convert.ToString(Num2.Text));

                if (ope == '+')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Soma(num1, num2)), 8);
                }
                else if (ope == '-')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.SubTrair(num1, num2)), 8);
                }
                else if (ope == '*')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Multiplicar(num1, num2)), 8);
                }
                else if (ope == '/')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Dividir(num1, num2)), 8);
                }
            }

            else if (EscolhaCalc.SelectedIndex == 3) // HexaDecimal
            {
                num1 = Conversor.FromHex(Convert.ToString(Num1.Text));
                num2 = Conversor.FromHex(Convert.ToString(Num2.Text));

                if (ope == '+')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Soma(num1, num2)), 16);
                }
                else if (ope == '-')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.SubTrair(num1, num2)), 16);
                }
                else if (ope == '*')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Multiplicar(num1, num2)), 16);
                }
                else if (ope == '/')
                {
                    Resultado.Text = Conversor.ToNumBase(Convert.ToString(Calculos.Dividir(num1, num2)), 16);
                }
            }

            else
            {

                num1 = Convert.ToDouble(Num1.Text);
                num2 = Convert.ToDouble(Num1.Text);

                if (ope == '+') Resultado.Text = Convert.ToString(Calculos.Soma(num1, num2));
                else if (ope == '-') Resultado.Text = Convert.ToString(Calculos.SubTrair(num1, num2));
                else if (ope == '*') Resultado.Text = Convert.ToString(Calculos.Multiplicar(num1, num2));
                else if (ope == '/') Resultado.Text = Convert.ToString(Calculos.Dividir(num1, num2));

            }

        }

        void ConvertText(int x)
        {
            if (x == 1) // Decimal
            {
                Binario.Text = Conversor.ToNumBase(Decimal.Text, 2);

                controleDouble = Conversor.FromBin(Binario.Text);
                Octal.Text = Conversor.ToNumBase(Convert.ToString(controleDouble), 8);

                HexaDecimal.Text = Conversor.ToNumBase(Decimal.Text, 16);
            }

            else if (x == 2) // Binario
            {
                controleString = Convert.ToString(Conversor.FromBin(Binario.Text));
                Decimal.Text = controleString;

                Octal.Text = Conversor.ToNumBase(Decimal.Text, 8);

                HexaDecimal.Text = Conversor.ToNumBase(Decimal.Text, 16);
            }

            else if (x == 3) // Octal
            {
                controleString = Convert.ToString(Conversor.FromOct(Octal.Text));
                Decimal.Text = controleString;

                Binario.Text = Conversor.ToNumBase(Decimal.Text, 2);

                HexaDecimal.Text = Conversor.ToNumBase(Decimal.Text, 16);
            }

            else if (x == 4) // HexaDecimal
            {
                controleString = Convert.ToString(Conversor.FromHex(HexaDecimal.Text));
                Decimal.Text = controleString;

                Binario.Text = Conversor.ToNumBase(Decimal.Text, 2);

                Octal.Text = Conversor.ToNumBase(Decimal.Text, 8);
            }
        }

#region EVENTO DOS TEXBOX CONVERSOR

        private void Decimal_TextChanged(object sender, EventArgs e)
        {
            Decimal.Text = Regex.Replace(Decimal.Text, "[^0-9]+", "");
            ConvertText(1);
        }

        private void Binario_TextChanged(object sender, EventArgs e)
        {
            Binario.Text = Regex.Replace(Binario.Text, "[^0-1]+", "");
            ConvertText(2);
        }

        private void Octal_TextChanged(object sender, EventArgs e)
        {
            Octal.Text = Regex.Replace(Octal.Text, "[^0-7]+", "");
            ConvertText(3);
        }

        private void HexaDecimal_TextChanged(object sender, EventArgs e)
        {
            HexaDecimal.Text = Regex.Replace(HexaDecimal.Text, "[^0-9A-Fa-f]+", "");
            ConvertText(4);
        }
        #endregion

#region BOTÕES OPERADORES

        private void BotaoSoma_Click(object sender, EventArgs e)
        {
            Calculo('+');
        }

        private void BotaoSubtrair_Click(object sender, EventArgs e)
        {
            Calculo('-');
        }

        private void BotaoDividir_Click(object sender, EventArgs e)
        {
            Calculo('/');
        }

        private void BotaoMultiplicar_Click(object sender, EventArgs e)
        {
            Calculo('*');
        }
        #endregion

        private void Num1_TextChanged(object sender, EventArgs e)
        {
            if (EscolhaCalc.SelectedIndex == 0) Num1.Text = Regex.Replace(Num1.Text, "[^0-9]+", "");
            else if (EscolhaCalc.SelectedIndex == 1) Num1.Text = Regex.Replace(Num1.Text, "[^0-1]+", "");
            else if (EscolhaCalc.SelectedIndex == 2) Num1.Text = Regex.Replace(Num1.Text, "[^0-7]+", "");
            else if (EscolhaCalc.SelectedIndex == 3) Num1.Text = Regex.Replace(Num1.Text, "[^0-9a-fA-F]+", "");
            else Num1.Text = Regex.Replace(Num1.Text, "[^0-9]+", "");
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            if (EscolhaCalc.SelectedIndex == 0) Num2.Text = Regex.Replace(Num2.Text, "[^0-9]+", "");
            else if (EscolhaCalc.SelectedIndex == 1) Num2.Text = Regex.Replace(Num2.Text, "[^0-1]+", "");
            else if (EscolhaCalc.SelectedIndex == 2) Num2.Text = Regex.Replace(Num2.Text, "[^0-7]+", "");
            else if (EscolhaCalc.SelectedIndex == 3) Num2.Text = Regex.Replace(Num2.Text, "[^0-9a-fA-F]+", "");
            else Num2.Text = Regex.Replace(Num2.Text, "[^0-9]+", "");
        }
    }
}
