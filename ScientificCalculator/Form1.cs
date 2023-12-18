using System;
using System.Text.RegularExpressions;

namespace ScientificCalculator
{

    public partial class Form1 : Form
    {
        private readonly int _strandardScreenWidth = 600;
        private readonly int _strandardTextResultWidth = 554;
        private readonly int _scientificScreenWidth = 1164;
        private readonly int _scientificTextResultWidth = 1122;
        private  string _numType="d";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 600;
            textResult.Width = 554;
        }

        private void enterNumber(object sender, EventArgs e)
        {
            string lastChar = textResult.Text.Last().ToString();
            Button num = (Button)sender;

            if (lastChar == "0" && textResult.Text.Length == 1)
            {
                textResult.Text = num.Text.ToString();
                return;
            }


            if (lastChar == "." && num.Text.ToString() == "." || num.Text.ToString() == "." && textResult.Text.Length == 0) return;

            textResult.Text += num.Text.ToString();
        }


        private static bool EndsWithOperator(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            char lastChar = input[input.Length - 1];
            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }

        private void numberOperators(object sender, EventArgs e)
        {

            if (EndsWithOperator(textResult.Text.ToString())) textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);

            runOperation();

            textResult.Text += ((Button)sender).Text.ToString();


        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            runOperation();
        }

        private static void ParseInput(string input, out double firstValue, out string operation, out double secondValue)
        {
            Regex regex = new Regex(@"(-?\d*\.?\d+)\s*(\+|\-|\*|\/|MOD|EXP)\s*(-?\d*\.?\d+)");
            Match match = regex.Match(input);

            if (match.Success)
            {
                firstValue = double.Parse(match.Groups[1].Value);
                operation = match.Groups[2].Value;
                secondValue = double.Parse(match.Groups[3].Value);
            }
            else
            {
                firstValue = 0;
                operation = "exception";
                secondValue = 0;
            }
        }

        private void runOperation()
        {
            ParseInput(textResult.Text, out double firstValue, out string operation, out double secondValue);

            textResult.Text = operation switch
            {
                "+" => (firstValue + secondValue).ToString(),
                "-" => (firstValue - secondValue).ToString(),
                "*" => (firstValue * secondValue).ToString(),
                "/" => (firstValue / secondValue).ToString(),
                "exception" => textResult.Text
            };

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            string firstNum;
            string secondNum;

            textResult.Text = "0";

            firstNum = "";
            secondNum = "";

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(-1 * Convert.ToDouble(textResult.Text));
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Remove(textResult.Text.Length - 1);
            }

            if (textResult.Text == "")
            {
                textResult.Text = "0";
            }
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = _strandardScreenWidth;
            textResult.Width = _strandardTextResultWidth;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = _scientificScreenWidth;
            textResult.Width = _scientificTextResultWidth;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            textResult.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textResult.Text)));
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textResult.Text)));
        }

        private void btnPower2_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textResult.Text), 2));
        }

        private void btnPower3_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textResult.Text), 3));
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(textResult.Text)));
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textResult.Text)));
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textResult.Text)));
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Cosh(Convert.ToDouble(textResult.Text)));
        }

        private void moduleCalculation(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Abs(Convert.ToDouble(textResult.Text)));
        }

        private static int FactorialRecursive(int number)
        {
            if (number <= 1) return 1;
            else return number * FactorialRecursive(number - 1);
        }

        private void factorialCalculation(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(FactorialRecursive((int)Math.Floor(Convert.ToDouble(textResult.Text))));
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Tanh(Convert.ToDouble(textResult.Text)));
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textResult.Text)));
        }

        private void btnOneDivideX_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textResult.Text)));
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(textResult.Text)));
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            textResult.Text = Convert.ToString(Convert.ToDouble(textResult.Text) / Convert.ToDouble(100));
        }


        public static string ConvertNumber(string from, string to, string value)
        {
            int decimalNumber = ConvertToDecimal(value, from);
            return ConvertFromDecimal(decimalNumber, to);
        }

        private static int ConvertToDecimal(string number, string fromBase)
        {
            fromBase = fromBase.ToLower();

            switch (fromBase)
            {
                case "b":
                    return Convert.ToInt32(number, 2);
                case "o":
                    return Convert.ToInt32(number, 8);
                case "d":
                    return int.Parse(number);
                case "h":
                    return Convert.ToInt32(number, 16);
                default:
                    throw new ArgumentException("Invalid source base.");
            }
        }

        private static string DecimalToOctal(int number)
        {
            string octalNumber = "";

            while (number > 0)
            {
                int remainder = number % 8;
                octalNumber = remainder.ToString() + octalNumber;
                number /= 8;
            }

            return octalNumber;
        }


        private static string ConvertFromDecimal(int decimalNumber, string toBase)
        {
            toBase = toBase.ToLower();

            switch (toBase)
            {
                case "b":
                    return Convert.ToString(decimalNumber, 2);
                case "o":
                    return Convert.ToString(decimalNumber, 8);
                case "d":
                    return decimalNumber.ToString();
                case "h":
                    return Convert.ToString(decimalNumber, 16).ToUpper();
                default:
                    throw new ArgumentException("Invalid target base.");
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {           
            string res= ConvertNumber(_numType, "d", textResult.Text);

            textResult.Text = res;

            _numType = "d";
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "b", textResult.Text);

            textResult.Text = res;

            _numType = "b";

        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "h", textResult.Text);

            textResult.Text = res;

            _numType = "h";

        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "o", textResult.Text);

            textResult.Text = res;

            _numType = "o";

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = Color.FromArgb(245, 246, 250);
            BackColor = Color.FromArgb(47, 54, 64);

            foreach (Control c in Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.FromArgb(131, 135, 141);
                }

                if (c is TextBox txt)
                {
                    txt.BackColor = Color.FromArgb(33, 41, 53);
                    txt.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = SystemColors.ControlText;
            BackColor = Color.White;

            foreach (Control c in Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = SystemColors.ControlLight;
                }

                if (c is TextBox txt)
                {
                    txt.BackColor = SystemColors.ControlLightLight;
                    txt.ForeColor = Color.Black;
                }
            }
        }
    }
}