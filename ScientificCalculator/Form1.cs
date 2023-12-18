namespace ScientificCalculator
{
     public partial class Form1 : Form
     {
          double enterFirstValue;
          double enterSecondValue;
          string op;
          int debounceCount = 0;

          private double currentResult = 0;
          private readonly int _strandardScreenWidth = 600;
          private readonly int _strandardTextResultWidth = 554;
          private readonly int _scientificScreenWidth = 1164;
          private readonly int _scientificTextResultWidth = 1122;
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

               Button num = (Button)sender;

               if (textResult.Text == "0")
                    textResult.Text = "";
               currentResult = 0;

               {
                    if (num.Text == ".")
                    {
                         if (!textResult.Text.Contains("."))
                         {
                              textResult.Text += num.Text;
                              currentResult = Convert.ToDouble(num.Text);
                         }
                    }
                    else
                    {
                         textResult.Text += num.Text;
                         currentResult += Convert.ToDouble(num.Text);
                    }
               }

               this.debounceCount += 1;
          }

          public string RemoveTrailingOperator(string input)
          {
               if (!string.IsNullOrEmpty(input) && "+-*/".Contains(input[^1]))
               {
                    return input[..^1]; // Remove the last character
               }

               return input; // Return the original string if no operator is found at the end
          }

          private void numberOperators(object sender, EventArgs e)
          {
               Button num = (Button)sender; 
               if (string.IsNullOrEmpty(textResult.Text))
               {
                    return;
               }

               string btn= textResult.Text.Last().ToString();
               bool IsOperator = (btn == "/" || btn == "*" || btn == "+" || btn == "-");
               
               bool IsModOrExp =false;
               if (textResult.Text.Length > 3) { 
               string last3Symb= textResult.Text.Substring(textResult.Text.Length - 3);

                    IsModOrExp = last3Symb == "Exp" || last3Symb == "Mod";
               }

               if (IsOperator) {
                    textResult.Text= textResult.Text.Substring(0, textResult.Text.Length - 1) + num.Text;
                    op = num.Text;

                    return;
               }

               if (IsModOrExp)
               {
                    textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 3) + num.Text;
                    op = num.Text;

                    return;
               }

               runOperation();
           

               enterFirstValue = Convert.ToDouble(RemoveTrailingOperator(textResult.Text));
               op = num.Text;
               textResult.Text = textResult.Text + num.Text;
          }

          public int GetSecondNumber(string input)
          {
               // Split the string based on common operators
               string[] parts = input.Split(new char[] { '+', '-', '*', '/' });

               // Check if there are at least two parts
               if (parts.Length >= 2)
               {
                    // Try to parse the second part as an integer
                    if (int.TryParse(parts[1], out int secondNumber))
                    {
                         return secondNumber;
                    }
               }

               // Return a default value or throw an exception if the parsing fails
               return 0; // or throw new InvalidOperationException("Invalid input format");
          }
          public bool ContainsOperator(string input)
          {
               string [] operators = { "+", "-", "*", "/", "p", "d" };
               bool contains;

               foreach (string op in operators)
               {
                    if (op.Contains(input[^1])) return true;
               }

               return false;
          }


          private void btnEqual_Click(object sender, EventArgs e)
          {
               runOperation();
          }

          private void runOperation()
          {
               if (ContainsOperator(textResult.Text)) return;

               enterSecondValue = GetSecondNumber(textResult.Text);

               switch (op)
               {
                    case "+":
                         currentResult = enterFirstValue + enterSecondValue;
                         textResult.Text = (enterFirstValue + enterSecondValue).ToString();
                         break;

                    case "-":
                         currentResult = enterFirstValue - enterSecondValue;
                         textResult.Text = (enterFirstValue - enterSecondValue).ToString();
                         break;

                    case "*":
                         currentResult = enterFirstValue * enterSecondValue;
                         textResult.Text = (enterFirstValue * enterSecondValue).ToString();
                         break;

                    case "/":
                         currentResult = enterFirstValue / enterSecondValue;
                         textResult.Text = (enterFirstValue / enterSecondValue).ToString();
                         break;

                    case "Mod":
                         currentResult = enterFirstValue % enterSecondValue;
                         textResult.Text = (enterFirstValue % enterSecondValue).ToString();
                         break;

                    case "Exp":
                         currentResult = Math.Exp(Convert.ToDouble(textResult.Text) * Math.Log(enterSecondValue * 4));
                         textResult.Text = Math.Exp(Convert.ToDouble(textResult.Text) * Math.Log(enterSecondValue * 4)).ToString();
                         break;

                    default: break;
               }
          }



          private void btnClear_Click(object sender, EventArgs e)
          {
               currentResult = 0;
               textResult.Text = "0";
          }

          private void btnClearEntry_Click(object sender, EventArgs e)
          {
               string firstNum;
               string secondNum;

               textResult.Text = "0";
               firstNum = Convert.ToString(enterFirstValue);
               secondNum = Convert.ToString(enterSecondValue);

               firstNum = "";
               secondNum = "";

               currentResult = Convert.ToDouble(textResult.Text);
          }

          private void btnPlusMinus_Click(object sender, EventArgs e)
          {
               currentResult = -1 * Convert.ToDouble(textResult.Text);
               textResult.Text = Convert.ToString(-1 * Convert.ToDouble(textResult.Text));
          }

          private void btnBackSpace_Click(object sender, EventArgs e)
          {
               if (textResult.Text.Length > 0)
               {
                    textResult.Text = textResult.Text.Remove(textResult.Text.Length - 1);
                    currentResult = Convert.ToDouble(textResult.Text);
               }

               if (textResult.Text == "")
               {
                    textResult.Text = "0";
                    currentResult = 0;
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
               currentResult = Math.PI;
               textResult.Text = Math.PI.ToString();
          }

          private void btnLog_Click(object sender, EventArgs e)
          {
               currentResult = Math.Log10(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textResult.Text)));
          }

          private void btnSqrt_Click(object sender, EventArgs e)
          {
               currentResult = Math.Sqrt(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textResult.Text)));
          }

          private void btnPower2_Click(object sender, EventArgs e)
          {
               currentResult = Math.Pow(Convert.ToDouble(textResult.Text), 2);
               textResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textResult.Text), 2));
          }

          private void btnPower3_Click(object sender, EventArgs e)
          {
               currentResult = Math.Pow(Convert.ToDouble(textResult.Text), 3);
               textResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textResult.Text), 3));
          }

          private void btnSinh_Click(object sender, EventArgs e)
          {
               currentResult = Math.Sinh(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(textResult.Text)));
          }

          private void btnSin_Click(object sender, EventArgs e)
          {
               currentResult = Math.Sin(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textResult.Text)));
          }

          private void btnCos_Click(object sender, EventArgs e)
          {
               currentResult = Math.Cos(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textResult.Text)));
          }

          private void btnCosh_Click(object sender, EventArgs e)
          {
               currentResult = Math.Cosh(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Cosh(Convert.ToDouble(textResult.Text)));
          }

          private void btnTanh_Click(object sender, EventArgs e)
          {
               currentResult = Math.Tanh(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Tanh(Convert.ToDouble(textResult.Text)));
          }

          private void btnTan_Click(object sender, EventArgs e)
          {
               currentResult = Math.Tan(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textResult.Text)));
          }

          private void btnOneDivideX_Click(object sender, EventArgs e)
          {
               currentResult = Convert.ToDouble(1.0 / Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textResult.Text)));
          }

          private void btnInx_Click(object sender, EventArgs e)
          {
               currentResult = Math.Log(Convert.ToDouble(textResult.Text));
               textResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(textResult.Text)));
          }

          private void btnPercent_Click(object sender, EventArgs e)
          {
               currentResult = Convert.ToDouble(textResult.Text) / Convert.ToDouble(100);
               textResult.Text = Convert.ToString(Convert.ToDouble(textResult.Text) / Convert.ToDouble(100));
          }

          private void btnDec_Click(object sender, EventArgs e)
          {
               currentResult = (int)Convert.ToDouble(textResult.Text);
               textResult.Text = Convert.ToString((int)Convert.ToDouble(textResult.Text));
          }

          private void btnBin_Click(object sender, EventArgs e)
          {
               currentResult = Convert.ToDouble(Convert.ToString(int.Parse(textResult.Text), 2));
               textResult.Text = Convert.ToString(int.Parse(textResult.Text), 2);
          }

          private void btnHex_Click(object sender, EventArgs e)
          {
               currentResult = Convert.ToDouble(Convert.ToString(int.Parse(textResult.Text), 16));
               textResult.Text = Convert.ToString(int.Parse(textResult.Text), 16);
          }

          private void btnOct_Click(object sender, EventArgs e)
          {
               currentResult = Convert.ToDouble(Convert.ToString(int.Parse(Convert.ToString((int)Math.Round(Convert.ToDouble(textResult.Text)))), 8));
               textResult.Text = Convert.ToString(int.Parse(textResult.Text), 8);
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