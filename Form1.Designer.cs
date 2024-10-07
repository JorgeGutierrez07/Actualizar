namespace CalculadoraWindows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTitle = new Panel();
            Minimizar = new Button();
            buttonExit = new Button();
            panelHistorial = new Panel();
            RtBoxDisplayHistory = new RichTextBox();
            botonLimpiarHistorial = new Button();
            panel1 = new Panel();
            botonHistorial = new Button();
            textDisplay2 = new TextBox();
            textDisplay1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            BtnBorrar = new Button();
            BtnClear = new Button();
            BtnCE = new Button();
            BtnPer = new Button();
            Btn1x = new Button();
            BtnExpo = new Button();
            BtnSqr = new Button();
            MultiDivision = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            BtnLess = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            BtnMulti = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            BtnPlus = new Button();
            BtnPM = new Button();
            Btn0 = new Button();
            BtnDecimal = new Button();
            BtnEqual = new Button();
            panelTitle.SuspendLayout();
            panelHistorial.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(Minimizar);
            panelTitle.Controls.Add(buttonExit);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(341, 39);
            panelTitle.TabIndex = 0;
            // 
            // Minimizar
            // 
            Minimizar.Cursor = Cursors.Hand;
            Minimizar.Dock = DockStyle.Right;
            Minimizar.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            Minimizar.FlatAppearance.MouseOverBackColor = Color.Gray;
            Minimizar.FlatStyle = FlatStyle.Flat;
            Minimizar.Location = new Point(233, 0);
            Minimizar.Margin = new Padding(0);
            Minimizar.Name = "Minimizar";
            Minimizar.Size = new Size(54, 39);
            Minimizar.TabIndex = 2;
            Minimizar.Text = "-";
            Minimizar.UseVisualStyleBackColor = true;
            Minimizar.Click += Minimizar_Click;
            // 
            // buttonExit
            // 
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(287, 0);
            buttonExit.Margin = new Padding(0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(54, 39);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button1_Click;
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(RtBoxDisplayHistory);
            panelHistorial.Controls.Add(botonLimpiarHistorial);
            panelHistorial.Dock = DockStyle.Bottom;
            panelHistorial.Location = new Point(0, 556);
            panelHistorial.Margin = new Padding(0);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(341, 5);
            panelHistorial.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.BackColor = Color.FromArgb(32, 32, 32);
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Dock = DockStyle.Fill;
            RtBoxDisplayHistory.ForeColor = Color.Silver;
            RtBoxDisplayHistory.Location = new Point(0, 0);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplayHistory.Size = new Size(341, 0);
            RtBoxDisplayHistory.TabIndex = 2;
            RtBoxDisplayHistory.Text = "";
            // 
            // botonLimpiarHistorial
            // 
            botonLimpiarHistorial.Cursor = Cursors.Hand;
            botonLimpiarHistorial.Dock = DockStyle.Bottom;
            botonLimpiarHistorial.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            botonLimpiarHistorial.FlatAppearance.MouseOverBackColor = Color.DimGray;
            botonLimpiarHistorial.FlatStyle = FlatStyle.Flat;
            botonLimpiarHistorial.Image = (Image)resources.GetObject("botonLimpiarHistorial.Image");
            botonLimpiarHistorial.Location = new Point(0, -34);
            botonLimpiarHistorial.Margin = new Padding(0);
            botonLimpiarHistorial.Name = "botonLimpiarHistorial";
            botonLimpiarHistorial.Size = new Size(341, 39);
            botonLimpiarHistorial.TabIndex = 1;
            botonLimpiarHistorial.UseVisualStyleBackColor = true;
            botonLimpiarHistorial.Click += botonLimpiarHistorial_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(botonHistorial);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 39);
            panel1.TabIndex = 2;
            // 
            // botonHistorial
            // 
            botonHistorial.Cursor = Cursors.Hand;
            botonHistorial.Dock = DockStyle.Right;
            botonHistorial.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            botonHistorial.FlatAppearance.MouseOverBackColor = Color.Gray;
            botonHistorial.FlatStyle = FlatStyle.Flat;
            botonHistorial.Image = (Image)resources.GetObject("botonHistorial.Image");
            botonHistorial.Location = new Point(287, 0);
            botonHistorial.Margin = new Padding(0);
            botonHistorial.Name = "botonHistorial";
            botonHistorial.Size = new Size(54, 39);
            botonHistorial.TabIndex = 0;
            botonHistorial.UseVisualStyleBackColor = true;
            botonHistorial.Click += botonHistorial_Click;
            // 
            // textDisplay2
            // 
            textDisplay2.BackColor = Color.FromArgb(32, 32, 32);
            textDisplay2.BorderStyle = BorderStyle.None;
            textDisplay2.Dock = DockStyle.Top;
            textDisplay2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay2.ForeColor = Color.DarkGray;
            textDisplay2.Location = new Point(0, 78);
            textDisplay2.Margin = new Padding(0);
            textDisplay2.Multiline = true;
            textDisplay2.Name = "textDisplay2";
            textDisplay2.Size = new Size(341, 25);
            textDisplay2.TabIndex = 3;
            textDisplay2.Text = "0";
            textDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // textDisplay1
            // 
            textDisplay1.BackColor = Color.FromArgb(32, 32, 32);
            textDisplay1.BorderStyle = BorderStyle.None;
            textDisplay1.Dock = DockStyle.Top;
            textDisplay1.Font = new Font("Gadugi", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay1.ForeColor = Color.DarkGray;
            textDisplay1.Location = new Point(0, 103);
            textDisplay1.Margin = new Padding(0);
            textDisplay1.Multiline = true;
            textDisplay1.Name = "textDisplay1";
            textDisplay1.Size = new Size(341, 61);
            textDisplay1.TabIndex = 4;
            textDisplay1.Text = "0";
            textDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 32, 32);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(276, 166);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(58, 30);
            button2.TabIndex = 6;
            button2.Text = "M~";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 32, 32);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DimGray;
            button3.Location = new Point(172, 166);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(50, 30);
            button3.TabIndex = 7;
            button3.Text = "M-";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 32, 32);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(8, 166);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(50, 30);
            button4.TabIndex = 8;
            button4.Text = "MC";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(32, 32, 32);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            button6.ForeColor = Color.DimGray;
            button6.Location = new Point(67, 166);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(50, 30);
            button6.TabIndex = 10;
            button6.Text = "MR";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(32, 32, 32);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            button7.ForeColor = Color.DimGray;
            button7.Location = new Point(121, 166);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(59, 30);
            button7.TabIndex = 11;
            button7.Text = "M+";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(32, 32, 32);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.DimGray;
            button8.Location = new Point(222, 166);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(50, 30);
            button8.TabIndex = 12;
            button8.Text = "MS";
            button8.UseVisualStyleBackColor = false;
            // 
            // BtnBorrar
            // 
            BtnBorrar.BackColor = Color.FromArgb(32, 32, 32);
            BtnBorrar.FlatAppearance.BorderSize = 0;
            BtnBorrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBorrar.FlatStyle = FlatStyle.Flat;
            BtnBorrar.Font = new Font("Gadugi", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBorrar.ForeColor = Color.DarkGray;
            BtnBorrar.Location = new Point(247, 210);
            BtnBorrar.Margin = new Padding(0);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(86, 55);
            BtnBorrar.TabIndex = 14;
            BtnBorrar.Text = "←";
            BtnBorrar.UseVisualStyleBackColor = false;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(32, 32, 32);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.DarkGray;
            BtnClear.Location = new Point(161, 210);
            BtnClear.Margin = new Padding(0);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(86, 55);
            BtnClear.TabIndex = 15;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.FromArgb(32, 32, 32);
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.ForeColor = Color.DarkGray;
            BtnCE.Location = new Point(84, 210);
            BtnCE.Margin = new Padding(0);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(86, 55);
            BtnCE.TabIndex = 16;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnPer
            // 
            BtnPer.BackColor = Color.FromArgb(32, 32, 32);
            BtnPer.FlatAppearance.BorderSize = 0;
            BtnPer.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPer.FlatStyle = FlatStyle.Flat;
            BtnPer.ForeColor = Color.DarkGray;
            BtnPer.Location = new Point(-2, 210);
            BtnPer.Margin = new Padding(0);
            BtnPer.Name = "BtnPer";
            BtnPer.Size = new Size(86, 55);
            BtnPer.TabIndex = 17;
            BtnPer.Text = "%";
            BtnPer.UseVisualStyleBackColor = false;
            BtnPer.Click += BtnOperacionesAvanzadas;
            // 
            // Btn1x
            // 
            Btn1x.BackColor = Color.FromArgb(32, 32, 32);
            Btn1x.FlatAppearance.BorderSize = 0;
            Btn1x.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn1x.FlatStyle = FlatStyle.Flat;
            Btn1x.ForeColor = Color.DarkGray;
            Btn1x.Location = new Point(-2, 265);
            Btn1x.Margin = new Padding(0);
            Btn1x.Name = "Btn1x";
            Btn1x.Size = new Size(86, 55);
            Btn1x.TabIndex = 21;
            Btn1x.Text = "⅓";
            Btn1x.UseVisualStyleBackColor = false;
            Btn1x.Click += BtnOperacionesAvanzadas;
            // 
            // BtnExpo
            // 
            BtnExpo.BackColor = Color.FromArgb(32, 32, 32);
            BtnExpo.FlatAppearance.BorderSize = 0;
            BtnExpo.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnExpo.FlatStyle = FlatStyle.Flat;
            BtnExpo.ForeColor = Color.DarkGray;
            BtnExpo.Location = new Point(84, 265);
            BtnExpo.Margin = new Padding(0);
            BtnExpo.Name = "BtnExpo";
            BtnExpo.Size = new Size(86, 55);
            BtnExpo.TabIndex = 20;
            BtnExpo.Text = "ˆ2";
            BtnExpo.UseVisualStyleBackColor = false;
            BtnExpo.Click += BtnOperacionesAvanzadas;
            // 
            // BtnSqr
            // 
            BtnSqr.BackColor = Color.FromArgb(32, 32, 32);
            BtnSqr.FlatAppearance.BorderSize = 0;
            BtnSqr.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnSqr.FlatStyle = FlatStyle.Flat;
            BtnSqr.ForeColor = Color.DarkGray;
            BtnSqr.Location = new Point(161, 265);
            BtnSqr.Margin = new Padding(0);
            BtnSqr.Name = "BtnSqr";
            BtnSqr.Size = new Size(86, 55);
            BtnSqr.TabIndex = 19;
            BtnSqr.Text = "√×";
            BtnSqr.UseVisualStyleBackColor = false;
            BtnSqr.Click += BtnOperacionesAvanzadas;
            // 
            // MultiDivision
            // 
            MultiDivision.BackColor = Color.FromArgb(32, 32, 32);
            MultiDivision.FlatAppearance.BorderSize = 0;
            MultiDivision.FlatAppearance.MouseOverBackColor = Color.Gray;
            MultiDivision.FlatStyle = FlatStyle.Flat;
            MultiDivision.ForeColor = Color.DarkGray;
            MultiDivision.Location = new Point(247, 265);
            MultiDivision.Margin = new Padding(0);
            MultiDivision.Name = "MultiDivision";
            MultiDivision.Size = new Size(86, 55);
            MultiDivision.TabIndex = 18;
            MultiDivision.Text = "∕";
            MultiDivision.UseVisualStyleBackColor = false;
            MultiDivision.Click += BtnOperaciones;
            // 
            // Btn4
            // 
            Btn4.BackColor = SystemColors.WindowFrame;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(-2, 375);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(86, 55);
            Btn4.TabIndex = 29;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = SystemColors.WindowFrame;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(84, 375);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(86, 55);
            Btn5.TabIndex = 28;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = SystemColors.WindowFrame;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(161, 375);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(86, 55);
            Btn6.TabIndex = 27;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BtnNum_Click;
            // 
            // BtnLess
            // 
            BtnLess.BackColor = Color.FromArgb(32, 32, 32);
            BtnLess.FlatAppearance.BorderSize = 0;
            BtnLess.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLess.FlatStyle = FlatStyle.Flat;
            BtnLess.ForeColor = Color.DarkGray;
            BtnLess.Location = new Point(247, 375);
            BtnLess.Margin = new Padding(0);
            BtnLess.Name = "BtnLess";
            BtnLess.Size = new Size(86, 55);
            BtnLess.TabIndex = 26;
            BtnLess.Text = "-";
            BtnLess.UseVisualStyleBackColor = false;
            BtnLess.Click += BtnOperaciones;
            // 
            // Btn7
            // 
            Btn7.BackColor = SystemColors.WindowFrame;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(-2, 320);
            Btn7.Margin = new Padding(0);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(86, 55);
            Btn7.TabIndex = 25;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = SystemColors.WindowFrame;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(84, 320);
            Btn8.Margin = new Padding(0);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(86, 55);
            Btn8.TabIndex = 24;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = SystemColors.WindowFrame;
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(161, 320);
            Btn9.Margin = new Padding(0);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(86, 55);
            Btn9.TabIndex = 23;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += BtnNum_Click;
            // 
            // BtnMulti
            // 
            BtnMulti.BackColor = Color.FromArgb(32, 32, 32);
            BtnMulti.FlatAppearance.BorderSize = 0;
            BtnMulti.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMulti.FlatStyle = FlatStyle.Flat;
            BtnMulti.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMulti.ForeColor = Color.DarkGray;
            BtnMulti.Location = new Point(247, 320);
            BtnMulti.Margin = new Padding(0);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(86, 55);
            BtnMulti.TabIndex = 22;
            BtnMulti.Text = "×";
            BtnMulti.UseVisualStyleBackColor = false;
            BtnMulti.Click += BtnOperaciones;
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.WindowFrame;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(-2, 430);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(86, 55);
            Btn1.TabIndex = 33;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = SystemColors.WindowFrame;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(84, 430);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(86, 55);
            Btn2.TabIndex = 32;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = SystemColors.WindowFrame;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(161, 430);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(86, 55);
            Btn3.TabIndex = 31;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += BtnNum_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(32, 32, 32);
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPlus.ForeColor = Color.DarkGray;
            BtnPlus.Location = new Point(247, 430);
            BtnPlus.Margin = new Padding(0);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(86, 55);
            BtnPlus.TabIndex = 30;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnOperaciones;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = SystemColors.WindowFrame;
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.ForeColor = Color.White;
            BtnPM.Location = new Point(-2, 485);
            BtnPM.Margin = new Padding(0);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(86, 55);
            BtnPM.TabIndex = 37;
            BtnPM.Text = "±";
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperacionesAvanzadas;
            // 
            // Btn0
            // 
            Btn0.BackColor = SystemColors.WindowFrame;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(84, 485);
            Btn0.Margin = new Padding(0);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(86, 55);
            Btn0.TabIndex = 36;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.BackColor = SystemColors.WindowFrame;
            BtnDecimal.FlatAppearance.BorderSize = 0;
            BtnDecimal.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnDecimal.FlatStyle = FlatStyle.Flat;
            BtnDecimal.ForeColor = Color.White;
            BtnDecimal.Location = new Point(161, 485);
            BtnDecimal.Margin = new Padding(0);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(86, 55);
            BtnDecimal.TabIndex = 35;
            BtnDecimal.Text = ".";
            BtnDecimal.UseVisualStyleBackColor = false;
            BtnDecimal.Click += BtnNum_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = SystemColors.Highlight;
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            BtnEqual.FlatStyle = FlatStyle.Flat;
            BtnEqual.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEqual.ForeColor = Color.Transparent;
            BtnEqual.Location = new Point(247, 485);
            BtnEqual.Margin = new Padding(0);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(86, 55);
            BtnEqual.TabIndex = 34;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(341, 561);
            Controls.Add(panelHistorial);
            Controls.Add(BtnPM);
            Controls.Add(Btn0);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnEqual);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(BtnPlus);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(BtnLess);
            Controls.Add(Btn7);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(BtnMulti);
            Controls.Add(Btn1x);
            Controls.Add(BtnExpo);
            Controls.Add(BtnSqr);
            Controls.Add(MultiDivision);
            Controls.Add(BtnPer);
            Controls.Add(BtnCE);
            Controls.Add(BtnClear);
            Controls.Add(BtnBorrar);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textDisplay1);
            Controls.Add(textDisplay2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTitle.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle;
        private Panel panelHistorial;
        private Button buttonExit;
        private Button Minimizar;
        private Panel panel1;
        private Button botonHistorial;
        private TextBox textDisplay2;
        private TextBox textDisplay1;
        private Button botonLimpiarHistorial;
        private RichTextBox RtBoxDisplayHistory;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button BtnBorrar;
        private Button BtnClear;
        private Button BtnCE;
        private Button BtnPer;
        private Button Btn1x;
        private Button BtnExpo;
        private Button BtnSqr;
        private Button MultiDivision;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button BtnLess;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnMulti;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnPlus;
        private Button BtnPM;
        private Button Btn0;
        private Button BtnDecimal;
        private Button BtnEqual;
    }
}
