namespace ScientificCalculator
{
     partial class Form1
     {
          private System.ComponentModel.IContainer components = null;

          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               btnBackSpace = new Button();
               textResult = new TextBox();
               btnPlusMinus = new Button();
               btnClear = new Button();
               btnClearEntry = new Button();
               btn8 = new Button();
               btn9 = new Button();
               btnPlus = new Button();
               btn7 = new Button();
               btn5 = new Button();
               btn6 = new Button();
               btnMinus = new Button();
               btn4 = new Button();
               btn2 = new Button();
               btn3 = new Button();
               btnMultiply = new Button();
               btn1 = new Button();
               btnDecimal = new Button();
               btnEqual = new Button();
               btnDivide = new Button();
               btn0 = new Button();
               menuStrip1 = new MenuStrip();
               standartToolStripMenuItem = new ToolStripMenuItem();
               scientificToolStripMenuItem = new ToolStripMenuItem();
               modeToolStripMenuItem = new ToolStripMenuItem();
               lightToolStripMenuItem = new ToolStripMenuItem();
               darkToolStripMenuItem = new ToolStripMenuItem();
               btnLog = new Button();
               btnSqrt = new Button();
               btnPower2 = new Button();
               btnPi = new Button();
               btnSin = new Button();
               btnDec = new Button();
               btnPower3 = new Button();
               btnSinh = new Button();
               btnCos = new Button();
               btnBin = new Button();
               btnOneDivideX = new Button();
               btnCosh = new Button();
               btnTan = new Button();
               btnHex = new Button();
               btnInx = new Button();
               btnTanh = new Button();
               btnMod = new Button();
               btnOct = new Button();
               btnPercent = new Button();
               btnExp = new Button();
               menuStrip1.SuspendLayout();
               SuspendLayout();
               // 
               // btnBackSpace
               // 
               btnBackSpace.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnBackSpace.Location = new Point(10, 78);
               btnBackSpace.Margin = new Padding(3, 2, 3, 2);
               btnBackSpace.Name = "btnBackSpace";
               btnBackSpace.Size = new Size(117, 77);
               btnBackSpace.TabIndex = 0;
               btnBackSpace.Text = "⌫";
               btnBackSpace.UseVisualStyleBackColor = true;
               btnBackSpace.Click += btnBackSpace_Click;
               // 
               // textResult
               // 
               textResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               textResult.Location = new Point(10, 31);
               textResult.Margin = new Padding(3, 2, 3, 2);
               textResult.Multiline = true;
               textResult.Name = "textResult";
               textResult.Size = new Size(485, 44);
               textResult.TabIndex = 1;
               textResult.Text = "0";
               textResult.TextAlign = HorizontalAlignment.Right;
               // 
               // btnPlusMinus
               // 
               btnPlusMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnPlusMinus.Location = new Point(378, 78);
               btnPlusMinus.Margin = new Padding(3, 2, 3, 2);
               btnPlusMinus.Name = "btnPlusMinus";
               btnPlusMinus.Size = new Size(117, 77);
               btnPlusMinus.TabIndex = 2;
               btnPlusMinus.Text = "±";
               btnPlusMinus.UseVisualStyleBackColor = true;
               btnPlusMinus.Click += btnPlusMinus_Click;
               // 
               // btnClear
               // 
               btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnClear.Location = new Point(256, 78);
               btnClear.Margin = new Padding(3, 2, 3, 2);
               btnClear.Name = "btnClear";
               btnClear.Size = new Size(117, 77);
               btnClear.TabIndex = 3;
               btnClear.Text = "C";
               btnClear.UseVisualStyleBackColor = true;
               btnClear.Click += btnClear_Click;
               // 
               // btnClearEntry
               // 
               btnClearEntry.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnClearEntry.Location = new Point(133, 78);
               btnClearEntry.Margin = new Padding(3, 2, 3, 2);
               btnClearEntry.Name = "btnClearEntry";
               btnClearEntry.Size = new Size(117, 77);
               btnClearEntry.TabIndex = 4;
               btnClearEntry.Text = "CE";
               btnClearEntry.UseVisualStyleBackColor = true;
               btnClearEntry.Click += btnClearEntry_Click;
               // 
               // btn8
               // 
               btn8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn8.Location = new Point(133, 166);
               btn8.Margin = new Padding(3, 2, 3, 2);
               btn8.Name = "btn8";
               btn8.Size = new Size(117, 77);
               btn8.TabIndex = 8;
               btn8.Text = "8";
               btn8.UseVisualStyleBackColor = true;
               btn8.Click += enterNumber;
               // 
               // btn9
               // 
               btn9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn9.Location = new Point(256, 166);
               btn9.Margin = new Padding(3, 2, 3, 2);
               btn9.Name = "btn9";
               btn9.Size = new Size(117, 77);
               btn9.TabIndex = 7;
               btn9.Text = "9";
               btn9.UseVisualStyleBackColor = true;
               btn9.Click += enterNumber;
               // 
               // btnPlus
               // 
               btnPlus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnPlus.Location = new Point(378, 166);
               btnPlus.Margin = new Padding(3, 2, 3, 2);
               btnPlus.Name = "btnPlus";
               btnPlus.Size = new Size(117, 77);
               btnPlus.TabIndex = 6;
               btnPlus.Text = "+";
               btnPlus.UseVisualStyleBackColor = true;
               btnPlus.Click += numberOperators;
               // 
               // btn7
               // 
               btn7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn7.Location = new Point(10, 166);
               btn7.Margin = new Padding(3, 2, 3, 2);
               btn7.Name = "btn7";
               btn7.Size = new Size(117, 77);
               btn7.TabIndex = 5;
               btn7.Text = "7";
               btn7.UseVisualStyleBackColor = true;
               btn7.Click += enterNumber;
               // 
               // btn5
               // 
               btn5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn5.Location = new Point(133, 255);
               btn5.Margin = new Padding(3, 2, 3, 2);
               btn5.Name = "btn5";
               btn5.Size = new Size(117, 77);
               btn5.TabIndex = 12;
               btn5.Text = "5";
               btn5.UseVisualStyleBackColor = true;
               btn5.Click += enterNumber;
               // 
               // btn6
               // 
               btn6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn6.Location = new Point(256, 255);
               btn6.Margin = new Padding(3, 2, 3, 2);
               btn6.Name = "btn6";
               btn6.Size = new Size(117, 77);
               btn6.TabIndex = 11;
               btn6.Text = "6";
               btn6.UseVisualStyleBackColor = true;
               btn6.Click += enterNumber;
               // 
               // btnMinus
               // 
               btnMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnMinus.Location = new Point(378, 255);
               btnMinus.Margin = new Padding(3, 2, 3, 2);
               btnMinus.Name = "btnMinus";
               btnMinus.Size = new Size(117, 77);
               btnMinus.TabIndex = 10;
               btnMinus.Text = "-";
               btnMinus.UseVisualStyleBackColor = true;
               btnMinus.Click += numberOperators;
               // 
               // btn4
               // 
               btn4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn4.Location = new Point(10, 255);
               btn4.Margin = new Padding(3, 2, 3, 2);
               btn4.Name = "btn4";
               btn4.Size = new Size(117, 77);
               btn4.TabIndex = 9;
               btn4.Text = "4";
               btn4.UseVisualStyleBackColor = true;
               btn4.Click += enterNumber;
               // 
               // btn2
               // 
               btn2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn2.Location = new Point(133, 344);
               btn2.Margin = new Padding(3, 2, 3, 2);
               btn2.Name = "btn2";
               btn2.Size = new Size(117, 77);
               btn2.TabIndex = 16;
               btn2.Text = "2";
               btn2.UseVisualStyleBackColor = true;
               btn2.Click += enterNumber;
               // 
               // btn3
               // 
               btn3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn3.Location = new Point(256, 344);
               btn3.Margin = new Padding(3, 2, 3, 2);
               btn3.Name = "btn3";
               btn3.Size = new Size(117, 77);
               btn3.TabIndex = 15;
               btn3.Text = "3";
               btn3.UseVisualStyleBackColor = true;
               btn3.Click += enterNumber;
               // 
               // btnMultiply
               // 
               btnMultiply.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnMultiply.Location = new Point(378, 344);
               btnMultiply.Margin = new Padding(3, 2, 3, 2);
               btnMultiply.Name = "btnMultiply";
               btnMultiply.Size = new Size(117, 77);
               btnMultiply.TabIndex = 14;
               btnMultiply.Text = "*";
               btnMultiply.UseVisualStyleBackColor = true;
               btnMultiply.Click += numberOperators;
               // 
               // btn1
               // 
               btn1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn1.Location = new Point(10, 344);
               btn1.Margin = new Padding(3, 2, 3, 2);
               btn1.Name = "btn1";
               btn1.Size = new Size(117, 77);
               btn1.TabIndex = 13;
               btn1.Text = "1";
               btn1.UseVisualStyleBackColor = true;
               btn1.Click += enterNumber;
               // 
               // btnDecimal
               // 
               btnDecimal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnDecimal.Location = new Point(133, 432);
               btnDecimal.Margin = new Padding(3, 2, 3, 2);
               btnDecimal.Name = "btnDecimal";
               btnDecimal.Size = new Size(117, 77);
               btnDecimal.TabIndex = 20;
               btnDecimal.Text = ".";
               btnDecimal.UseVisualStyleBackColor = true;
               btnDecimal.Click += enterNumber;
               // 
               // btnEqual
               // 
               btnEqual.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnEqual.Location = new Point(256, 432);
               btnEqual.Margin = new Padding(3, 2, 3, 2);
               btnEqual.Name = "btnEqual";
               btnEqual.Size = new Size(117, 77);
               btnEqual.TabIndex = 19;
               btnEqual.Text = "=";
               btnEqual.UseVisualStyleBackColor = true;
               btnEqual.Click += btnEqual_Click;
               // 
               // btnDivide
               // 
               btnDivide.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnDivide.Location = new Point(378, 432);
               btnDivide.Margin = new Padding(3, 2, 3, 2);
               btnDivide.Name = "btnDivide";
               btnDivide.Size = new Size(117, 77);
               btnDivide.TabIndex = 18;
               btnDivide.Text = "/";
               btnDivide.UseVisualStyleBackColor = true;
               btnDivide.Click += numberOperators;
               // 
               // btn0
               // 
               btn0.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btn0.Location = new Point(10, 432);
               btn0.Margin = new Padding(3, 2, 3, 2);
               btn0.Name = "btn0";
               btn0.Size = new Size(117, 77);
               btn0.TabIndex = 17;
               btn0.Text = "0";
               btn0.UseVisualStyleBackColor = true;
               btn0.Click += enterNumber;
               // 
               // menuStrip1
               // 
               menuStrip1.ImageScalingSize = new Size(20, 20);
               menuStrip1.Items.AddRange(new ToolStripItem[] { standartToolStripMenuItem, scientificToolStripMenuItem, modeToolStripMenuItem });
               menuStrip1.Location = new Point(0, 0);
               menuStrip1.Name = "menuStrip1";
               menuStrip1.Padding = new Padding(5, 2, 0, 2);
               menuStrip1.Size = new Size(1184, 29);
               menuStrip1.TabIndex = 21;
               menuStrip1.Text = "menuStrip1";
               // 
               // standartToolStripMenuItem
               // 
               standartToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
               standartToolStripMenuItem.Name = "standartToolStripMenuItem";
               standartToolStripMenuItem.Size = new Size(80, 25);
               standartToolStripMenuItem.Text = "Standart";
               standartToolStripMenuItem.Click += standartToolStripMenuItem_Click;
               // 
               // scientificToolStripMenuItem
               // 
               scientificToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
               scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
               scientificToolStripMenuItem.Size = new Size(84, 25);
               scientificToolStripMenuItem.Text = "Scientific";
               scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
               // 
               // modeToolStripMenuItem
               // 
               modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
               modeToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
               modeToolStripMenuItem.Name = "modeToolStripMenuItem";
               modeToolStripMenuItem.Size = new Size(62, 25);
               modeToolStripMenuItem.Text = "Mode";
               // 
               // lightToolStripMenuItem
               // 
               lightToolStripMenuItem.Name = "lightToolStripMenuItem";
               lightToolStripMenuItem.Size = new Size(180, 26);
               lightToolStripMenuItem.Text = "Light";
               lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
               // 
               // darkToolStripMenuItem
               // 
               darkToolStripMenuItem.Name = "darkToolStripMenuItem";
               darkToolStripMenuItem.Size = new Size(180, 26);
               darkToolStripMenuItem.Text = "Dark";
               darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
               // 
               // btnLog
               // 
               btnLog.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnLog.Location = new Point(632, 78);
               btnLog.Margin = new Padding(3, 2, 3, 2);
               btnLog.Name = "btnLog";
               btnLog.Size = new Size(117, 77);
               btnLog.TabIndex = 25;
               btnLog.Text = "Log";
               btnLog.UseVisualStyleBackColor = true;
               btnLog.Click += btnLog_Click;
               // 
               // btnSqrt
               // 
               btnSqrt.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
               btnSqrt.Location = new Point(755, 78);
               btnSqrt.Margin = new Padding(3, 2, 3, 2);
               btnSqrt.Name = "btnSqrt";
               btnSqrt.Size = new Size(117, 77);
               btnSqrt.TabIndex = 24;
               btnSqrt.Text = "√";
               btnSqrt.UseVisualStyleBackColor = true;
               btnSqrt.Click += btnSqrt_Click;
               // 
               // btnPower2
               // 
               btnPower2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnPower2.Location = new Point(877, 78);
               btnPower2.Margin = new Padding(3, 2, 3, 2);
               btnPower2.Name = "btnPower2";
               btnPower2.Size = new Size(117, 77);
               btnPower2.TabIndex = 23;
               btnPower2.Text = "x²";
               btnPower2.UseVisualStyleBackColor = true;
               btnPower2.Click += btnPower2_Click;
               // 
               // btnPi
               // 
               btnPi.Font = new Font("Centaur", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
               btnPi.Location = new Point(509, 78);
               btnPi.Margin = new Padding(3, 2, 3, 2);
               btnPi.Name = "btnPi";
               btnPi.Size = new Size(117, 77);
               btnPi.TabIndex = 22;
               btnPi.Text = "π";
               btnPi.UseVisualStyleBackColor = true;
               btnPi.Click += btnPi_Click;
               // 
               // btnSin
               // 
               btnSin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnSin.Location = new Point(632, 166);
               btnSin.Margin = new Padding(3, 2, 3, 2);
               btnSin.Name = "btnSin";
               btnSin.Size = new Size(117, 77);
               btnSin.TabIndex = 29;
               btnSin.Text = "Sin";
               btnSin.UseVisualStyleBackColor = true;
               btnSin.Click += btnSin_Click;
               // 
               // btnDec
               // 
               btnDec.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnDec.Location = new Point(755, 166);
               btnDec.Margin = new Padding(3, 2, 3, 2);
               btnDec.Name = "btnDec";
               btnDec.Size = new Size(117, 77);
               btnDec.TabIndex = 28;
               btnDec.Text = "Dec";
               btnDec.UseVisualStyleBackColor = true;
               btnDec.Click += btnDec_Click;
               // 
               // btnPower3
               // 
               btnPower3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnPower3.Location = new Point(877, 166);
               btnPower3.Margin = new Padding(3, 2, 3, 2);
               btnPower3.Name = "btnPower3";
               btnPower3.Size = new Size(117, 77);
               btnPower3.TabIndex = 27;
               btnPower3.Text = "x³";
               btnPower3.UseVisualStyleBackColor = true;
               btnPower3.Click += btnPower3_Click;
               // 
               // btnSinh
               // 
               btnSinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnSinh.Location = new Point(509, 166);
               btnSinh.Margin = new Padding(3, 2, 3, 2);
               btnSinh.Name = "btnSinh";
               btnSinh.Size = new Size(117, 77);
               btnSinh.TabIndex = 26;
               btnSinh.Text = "Sinh";
               btnSinh.UseVisualStyleBackColor = true;
               btnSinh.Click += btnSinh_Click;
               // 
               // btnCos
               // 
               btnCos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnCos.Location = new Point(632, 255);
               btnCos.Margin = new Padding(3, 2, 3, 2);
               btnCos.Name = "btnCos";
               btnCos.Size = new Size(117, 77);
               btnCos.TabIndex = 33;
               btnCos.Text = "Cos";
               btnCos.UseVisualStyleBackColor = true;
               btnCos.Click += btnCos_Click;
               // 
               // btnBin
               // 
               btnBin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnBin.Location = new Point(755, 255);
               btnBin.Margin = new Padding(3, 2, 3, 2);
               btnBin.Name = "btnBin";
               btnBin.Size = new Size(117, 77);
               btnBin.TabIndex = 32;
               btnBin.Text = "Bin";
               btnBin.UseVisualStyleBackColor = true;
               btnBin.Click += btnBin_Click;
               // 
               // btnOneDivideX
               // 
               btnOneDivideX.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnOneDivideX.Location = new Point(877, 255);
               btnOneDivideX.Margin = new Padding(3, 2, 3, 2);
               btnOneDivideX.Name = "btnOneDivideX";
               btnOneDivideX.Size = new Size(117, 77);
               btnOneDivideX.TabIndex = 31;
               btnOneDivideX.Text = "1/x";
               btnOneDivideX.UseVisualStyleBackColor = true;
               btnOneDivideX.Click += btnOneDivideX_Click;
               // 
               // btnCosh
               // 
               btnCosh.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnCosh.Location = new Point(509, 255);
               btnCosh.Margin = new Padding(3, 2, 3, 2);
               btnCosh.Name = "btnCosh";
               btnCosh.Size = new Size(117, 77);
               btnCosh.TabIndex = 30;
               btnCosh.Text = "Cosh";
               btnCosh.UseVisualStyleBackColor = true;
               btnCosh.Click += btnCosh_Click;
               // 
               // btnTan
               // 
               btnTan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnTan.Location = new Point(632, 344);
               btnTan.Margin = new Padding(3, 2, 3, 2);
               btnTan.Name = "btnTan";
               btnTan.Size = new Size(117, 77);
               btnTan.TabIndex = 37;
               btnTan.Text = "Tan";
               btnTan.UseVisualStyleBackColor = true;
               btnTan.Click += btnTan_Click;
               // 
               // btnHex
               // 
               btnHex.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnHex.Location = new Point(755, 344);
               btnHex.Margin = new Padding(3, 2, 3, 2);
               btnHex.Name = "btnHex";
               btnHex.Size = new Size(117, 77);
               btnHex.TabIndex = 36;
               btnHex.Text = "Hex";
               btnHex.UseVisualStyleBackColor = true;
               btnHex.Click += btnHex_Click;
               // 
               // btnInx
               // 
               btnInx.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnInx.Location = new Point(877, 344);
               btnInx.Margin = new Padding(3, 2, 3, 2);
               btnInx.Name = "btnInx";
               btnInx.Size = new Size(117, 77);
               btnInx.TabIndex = 35;
               btnInx.Text = "In x";
               btnInx.UseVisualStyleBackColor = false;
               btnInx.Click += btnInx_Click;
               // 
               // btnTanh
               // 
               btnTanh.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnTanh.Location = new Point(509, 344);
               btnTanh.Margin = new Padding(3, 2, 3, 2);
               btnTanh.Name = "btnTanh";
               btnTanh.Size = new Size(117, 77);
               btnTanh.TabIndex = 34;
               btnTanh.Text = "Tanh";
               btnTanh.UseVisualStyleBackColor = true;
               btnTanh.Click += btnTanh_Click;
               // 
               // btnMod
               // 
               btnMod.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnMod.Location = new Point(632, 432);
               btnMod.Margin = new Padding(3, 2, 3, 2);
               btnMod.Name = "btnMod";
               btnMod.Size = new Size(117, 77);
               btnMod.TabIndex = 41;
               btnMod.Text = "Mod";
               btnMod.UseVisualStyleBackColor = true;
               btnMod.Click += numberOperators;
               // 
               // btnOct
               // 
               btnOct.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnOct.Location = new Point(755, 432);
               btnOct.Margin = new Padding(3, 2, 3, 2);
               btnOct.Name = "btnOct";
               btnOct.Size = new Size(117, 77);
               btnOct.TabIndex = 40;
               btnOct.Text = "Oct";
               btnOct.UseVisualStyleBackColor = true;
               btnOct.Click += btnOct_Click;
               // 
               // btnPercent
               // 
               btnPercent.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnPercent.Location = new Point(877, 432);
               btnPercent.Margin = new Padding(3, 2, 3, 2);
               btnPercent.Name = "btnPercent";
               btnPercent.Size = new Size(117, 77);
               btnPercent.TabIndex = 39;
               btnPercent.Text = "%";
               btnPercent.UseVisualStyleBackColor = true;
               btnPercent.Click += btnPercent_Click;
               // 
               // btnExp
               // 
               btnExp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
               btnExp.Location = new Point(509, 432);
               btnExp.Margin = new Padding(3, 2, 3, 2);
               btnExp.Name = "btnExp";
               btnExp.Size = new Size(117, 77);
               btnExp.TabIndex = 38;
               btnExp.Text = "Exp";
               btnExp.UseVisualStyleBackColor = true;
               btnExp.Click += numberOperators;
               // 
               // Form1
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1184, 520);
               Controls.Add(btnMod);
               Controls.Add(btnOct);
               Controls.Add(btnPercent);
               Controls.Add(btnExp);
               Controls.Add(btnTan);
               Controls.Add(btnHex);
               Controls.Add(btnInx);
               Controls.Add(btnTanh);
               Controls.Add(btnCos);
               Controls.Add(btnBin);
               Controls.Add(btnOneDivideX);
               Controls.Add(btnCosh);
               Controls.Add(btnSin);
               Controls.Add(btnDec);
               Controls.Add(btnPower3);
               Controls.Add(btnSinh);
               Controls.Add(btnLog);
               Controls.Add(btnSqrt);
               Controls.Add(btnPower2);
               Controls.Add(btnPi);
               Controls.Add(btnDecimal);
               Controls.Add(btnEqual);
               Controls.Add(btnDivide);
               Controls.Add(btn0);
               Controls.Add(btn2);
               Controls.Add(btn3);
               Controls.Add(btnMultiply);
               Controls.Add(btn1);
               Controls.Add(btn5);
               Controls.Add(btn6);
               Controls.Add(btnMinus);
               Controls.Add(btn4);
               Controls.Add(btn8);
               Controls.Add(btn9);
               Controls.Add(btnPlus);
               Controls.Add(btn7);
               Controls.Add(btnClearEntry);
               Controls.Add(btnClear);
               Controls.Add(btnPlusMinus);
               Controls.Add(textResult);
               Controls.Add(btnBackSpace);
               Controls.Add(menuStrip1);
               MainMenuStrip = menuStrip1;
               Margin = new Padding(3, 2, 3, 2);
               Name = "Form1";
               Text = "Form1";
               Load += Form1_Load;
               menuStrip1.ResumeLayout(false);
               menuStrip1.PerformLayout();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnBackSpace;
          private TextBox textResult;

          private Button btnPlusMinus;
          private Button btnClear;
          private Button btnClearEntry;
          private Button btn8;
          private Button btn9;
          private Button btnPlus;
          private Button btn7;
          private Button btn5;
          private Button btn6;
          private Button btnMinus;
          private Button btn4;
          private Button btn2;
          private Button btn3;
          private Button btnMultiply;
          private Button btn1;
          private Button btnDecimal;
          private Button btnEqual;
          private Button btnDivide;
          private Button btn0;
          private MenuStrip menuStrip1;
          private ToolStripMenuItem standartToolStripMenuItem;
          private ToolStripMenuItem scientificToolStripMenuItem;
          private Button btnLog;
          private Button btnSqrt;
          private Button btnPower2;
          private Button btnPi;
          private Button btnSin;
          private Button btnDec;
          private Button btnPower3;
          private Button btnSinh;
          private Button btnCos;
          private Button btnBin;
          private Button btnOneDivideX;
          private Button btnCosh;
          private Button btnTan;
          private Button btnHex;
          private Button btnInx;
          private Button btnTanh;
          private Button btnMod;
          private Button btnOct;
          private Button btnPercent;
          private Button btnExp;
          private ToolStripMenuItem modeToolStripMenuItem;
          private ToolStripMenuItem lightToolStripMenuItem;
          private ToolStripMenuItem darkToolStripMenuItem;
     }
}