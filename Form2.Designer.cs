namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            resultado = new Label();
            botao_delete = new Button();
            botao_divisão = new Button();
            botao_multiplicação = new Button();
            button12 = new Button();
            button11 = new Button();
            botao_igual = new Button();
            botao_09 = new Button();
            botao_08 = new Button();
            botao_07 = new Button();
            botao_06 = new Button();
            botao_05 = new Button();
            botao_04 = new Button();
            botao_03 = new Button();
            botao_02 = new Button();
            botao_01 = new Button();
            botao_00 = new Button();
            botao_soma = new Button();
            botao_subtração = new Button();
            menuStrip1 = new MenuStrip();
            conversãoToolStripMenuItem = new ToolStripMenuItem();
            celsius_para_fahrenheit = new ToolStripMenuItem();
            cmParaPolegadaToolStripMenuItem = new ToolStripMenuItem();
            calculadora_sair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.BackColor = Color.DarkGreen;
            resultado.BorderStyle = BorderStyle.FixedSingle;
            resultado.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultado.ForeColor = Color.White;
            resultado.Location = new Point(10, 78);
            resultado.Name = "resultado";
            resultado.Size = new Size(325, 93);
            resultado.TabIndex = 33;
            resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botao_delete
            // 
            botao_delete.BackColor = Color.DarkGreen;
            botao_delete.FlatStyle = FlatStyle.Popup;
            botao_delete.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_delete.ForeColor = Color.White;
            botao_delete.Location = new Point(360, 91);
            botao_delete.Name = "botao_delete";
            botao_delete.Size = new Size(93, 37);
            botao_delete.TabIndex = 32;
            botao_delete.Text = "<_x_]";
            botao_delete.UseVisualStyleBackColor = false;
            botao_delete.Click += botao_delete_Click;
            // 
            // botao_divisão
            // 
            botao_divisão.BackColor = Color.DarkGreen;
            botao_divisão.FlatStyle = FlatStyle.Popup;
            botao_divisão.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_divisão.ForeColor = Color.White;
            botao_divisão.Location = new Point(360, 134);
            botao_divisão.Name = "botao_divisão";
            botao_divisão.Size = new Size(93, 37);
            botao_divisão.TabIndex = 31;
            botao_divisão.Text = "--:--";
            botao_divisão.UseVisualStyleBackColor = false;
            botao_divisão.Click += botao_divisão_Click;
            // 
            // botao_multiplicação
            // 
            botao_multiplicação.BackColor = Color.DarkGreen;
            botao_multiplicação.FlatStyle = FlatStyle.Popup;
            botao_multiplicação.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_multiplicação.ForeColor = Color.White;
            botao_multiplicação.Location = new Point(360, 177);
            botao_multiplicação.Name = "botao_multiplicação";
            botao_multiplicação.Size = new Size(93, 37);
            botao_multiplicação.TabIndex = 30;
            botao_multiplicação.Text = "x";
            botao_multiplicação.UseVisualStyleBackColor = false;
            botao_multiplicação.Click += botao_multiplicação_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Arial", 12F, FontStyle.Italic);
            button12.Location = new Point(360, 220);
            button12.Name = "button12";
            button12.Size = new Size(93, 37);
            button12.TabIndex = 29;
            button12.Text = "--";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Arial", 12F, FontStyle.Italic);
            button11.Location = new Point(360, 263);
            button11.Name = "button11";
            button11.Size = new Size(93, 37);
            button11.TabIndex = 28;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            // 
            // botao_igual
            // 
            botao_igual.BackColor = Color.DarkGreen;
            botao_igual.FlatStyle = FlatStyle.Popup;
            botao_igual.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_igual.ForeColor = Color.White;
            botao_igual.Location = new Point(360, 306);
            botao_igual.Name = "botao_igual";
            botao_igual.Size = new Size(93, 37);
            botao_igual.TabIndex = 27;
            botao_igual.Text = "=";
            botao_igual.UseVisualStyleBackColor = false;
            botao_igual.Click += botao_igual_Click;
            // 
            // botao_09
            // 
            botao_09.BackColor = Color.DarkGreen;
            botao_09.FlatStyle = FlatStyle.Popup;
            botao_09.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_09.ForeColor = Color.White;
            botao_09.Location = new Point(242, 177);
            botao_09.Name = "botao_09";
            botao_09.Size = new Size(93, 37);
            botao_09.TabIndex = 26;
            botao_09.Text = "9";
            botao_09.UseVisualStyleBackColor = false;
            botao_09.Click += botao_09_Click;
            // 
            // botao_08
            // 
            botao_08.BackColor = Color.DarkGreen;
            botao_08.FlatStyle = FlatStyle.Popup;
            botao_08.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_08.ForeColor = Color.White;
            botao_08.Location = new Point(127, 177);
            botao_08.Name = "botao_08";
            botao_08.Size = new Size(93, 37);
            botao_08.TabIndex = 25;
            botao_08.Text = "8";
            botao_08.UseVisualStyleBackColor = false;
            botao_08.Click += botao_08_Click;
            // 
            // botao_07
            // 
            botao_07.BackColor = Color.DarkGreen;
            botao_07.FlatStyle = FlatStyle.Popup;
            botao_07.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_07.ForeColor = Color.White;
            botao_07.Location = new Point(10, 177);
            botao_07.Name = "botao_07";
            botao_07.Size = new Size(93, 37);
            botao_07.TabIndex = 24;
            botao_07.Text = "7";
            botao_07.UseVisualStyleBackColor = false;
            botao_07.Click += botao_07_Click;
            // 
            // botao_06
            // 
            botao_06.BackColor = Color.DarkGreen;
            botao_06.FlatStyle = FlatStyle.Popup;
            botao_06.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_06.ForeColor = Color.White;
            botao_06.Location = new Point(242, 220);
            botao_06.Name = "botao_06";
            botao_06.Size = new Size(93, 37);
            botao_06.TabIndex = 23;
            botao_06.Text = "6";
            botao_06.UseVisualStyleBackColor = false;
            botao_06.Click += botao_06_Click;
            // 
            // botao_05
            // 
            botao_05.BackColor = Color.DarkGreen;
            botao_05.FlatStyle = FlatStyle.Popup;
            botao_05.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_05.ForeColor = Color.White;
            botao_05.Location = new Point(127, 220);
            botao_05.Name = "botao_05";
            botao_05.Size = new Size(93, 37);
            botao_05.TabIndex = 22;
            botao_05.Text = "5";
            botao_05.UseVisualStyleBackColor = false;
            botao_05.Click += botao_05_Click;
            // 
            // botao_04
            // 
            botao_04.BackColor = Color.DarkGreen;
            botao_04.FlatStyle = FlatStyle.Popup;
            botao_04.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_04.ForeColor = Color.White;
            botao_04.Location = new Point(10, 220);
            botao_04.Name = "botao_04";
            botao_04.Size = new Size(93, 37);
            botao_04.TabIndex = 21;
            botao_04.Text = "4";
            botao_04.UseVisualStyleBackColor = false;
            botao_04.Click += botao_04_Click;
            // 
            // botao_03
            // 
            botao_03.BackColor = Color.DarkGreen;
            botao_03.FlatStyle = FlatStyle.Popup;
            botao_03.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_03.ForeColor = Color.White;
            botao_03.Location = new Point(242, 263);
            botao_03.Name = "botao_03";
            botao_03.Size = new Size(93, 37);
            botao_03.TabIndex = 20;
            botao_03.Text = "3";
            botao_03.UseVisualStyleBackColor = false;
            botao_03.Click += botao_03_Click;
            // 
            // botao_02
            // 
            botao_02.BackColor = Color.DarkGreen;
            botao_02.FlatStyle = FlatStyle.Popup;
            botao_02.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_02.ForeColor = Color.White;
            botao_02.Location = new Point(127, 263);
            botao_02.Name = "botao_02";
            botao_02.Size = new Size(93, 37);
            botao_02.TabIndex = 19;
            botao_02.Text = "2";
            botao_02.UseVisualStyleBackColor = false;
            botao_02.Click += botao_02_Click;
            // 
            // botao_01
            // 
            botao_01.BackColor = Color.DarkGreen;
            botao_01.FlatStyle = FlatStyle.Popup;
            botao_01.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_01.ForeColor = Color.White;
            botao_01.Location = new Point(10, 263);
            botao_01.Name = "botao_01";
            botao_01.Size = new Size(93, 37);
            botao_01.TabIndex = 18;
            botao_01.Text = "1";
            botao_01.UseVisualStyleBackColor = false;
            botao_01.Click += botao_01_Click;
            // 
            // botao_00
            // 
            botao_00.BackColor = Color.DarkGreen;
            botao_00.FlatStyle = FlatStyle.Popup;
            botao_00.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_00.ForeColor = Color.White;
            botao_00.Location = new Point(127, 306);
            botao_00.Name = "botao_00";
            botao_00.Size = new Size(93, 37);
            botao_00.TabIndex = 17;
            botao_00.Text = "0";
            botao_00.UseVisualStyleBackColor = false;
            botao_00.Click += botao_00_Click;
            // 
            // botao_soma
            // 
            botao_soma.BackColor = Color.DarkGreen;
            botao_soma.FlatStyle = FlatStyle.Popup;
            botao_soma.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_soma.ForeColor = Color.White;
            botao_soma.Location = new Point(360, 263);
            botao_soma.Name = "botao_soma";
            botao_soma.Size = new Size(93, 37);
            botao_soma.TabIndex = 28;
            botao_soma.Text = "+";
            botao_soma.UseVisualStyleBackColor = false;
            botao_soma.Click += botao_soma_Click;
            // 
            // botao_subtração
            // 
            botao_subtração.BackColor = Color.DarkGreen;
            botao_subtração.FlatStyle = FlatStyle.Popup;
            botao_subtração.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            botao_subtração.ForeColor = Color.White;
            botao_subtração.Location = new Point(360, 220);
            botao_subtração.Name = "botao_subtração";
            botao_subtração.Size = new Size(93, 37);
            botao_subtração.TabIndex = 29;
            botao_subtração.Text = "--";
            botao_subtração.UseVisualStyleBackColor = false;
            botao_subtração.Click += botao_subtração_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { conversãoToolStripMenuItem, calculadora_sair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(469, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // conversãoToolStripMenuItem
            // 
            conversãoToolStripMenuItem.BackColor = Color.DarkGreen;
            conversãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { celsius_para_fahrenheit, cmParaPolegadaToolStripMenuItem });
            conversãoToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            conversãoToolStripMenuItem.ForeColor = Color.White;
            conversãoToolStripMenuItem.Name = "conversãoToolStripMenuItem";
            conversãoToolStripMenuItem.Size = new Size(80, 20);
            conversãoToolStripMenuItem.Text = "Conversão";
            // 
            // celsius_para_fahrenheit
            // 
            celsius_para_fahrenheit.BackColor = Color.DarkGreen;
            celsius_para_fahrenheit.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            celsius_para_fahrenheit.ForeColor = Color.White;
            celsius_para_fahrenheit.Name = "celsius_para_fahrenheit";
            celsius_para_fahrenheit.Size = new Size(242, 22);
            celsius_para_fahrenheit.Text = "Celsius para Fahrenheit";
            celsius_para_fahrenheit.Click += celsius_para_fahrenheit_Click;
            // 
            // cmParaPolegadaToolStripMenuItem
            // 
            cmParaPolegadaToolStripMenuItem.BackColor = Color.DarkGreen;
            cmParaPolegadaToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmParaPolegadaToolStripMenuItem.ForeColor = Color.White;
            cmParaPolegadaToolStripMenuItem.Name = "cmParaPolegadaToolStripMenuItem";
            cmParaPolegadaToolStripMenuItem.Size = new Size(242, 22);
            cmParaPolegadaToolStripMenuItem.Text = "Centímetros para Polegadas ";
            cmParaPolegadaToolStripMenuItem.Click += cmParaPolegadaToolStripMenuItem_Click;
            // 
            // calculadora_sair
            // 
            calculadora_sair.BackColor = Color.DarkGreen;
            calculadora_sair.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            calculadora_sair.ForeColor = Color.White;
            calculadora_sair.Name = "calculadora_sair";
            calculadora_sair.Size = new Size(42, 20);
            calculadora_sair.Text = "Sair";
            calculadora_sair.Click += calculadora_sair_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(469, 346);
            Controls.Add(resultado);
            Controls.Add(botao_delete);
            Controls.Add(botao_divisão);
            Controls.Add(botao_multiplicação);
            Controls.Add(botao_subtração);
            Controls.Add(button12);
            Controls.Add(botao_soma);
            Controls.Add(button11);
            Controls.Add(botao_igual);
            Controls.Add(botao_09);
            Controls.Add(botao_08);
            Controls.Add(botao_07);
            Controls.Add(botao_06);
            Controls.Add(botao_05);
            Controls.Add(botao_04);
            Controls.Add(botao_03);
            Controls.Add(botao_02);
            Controls.Add(botao_01);
            Controls.Add(botao_00);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            FormClosed += Calculadora_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultado;
        private Button botao_delete;
        private Button botao_divisão;
        private Button botao_multiplicação;
        private Button button12;
        private Button button11;
        private Button botao_igual;
        private Button botao_09;
        private Button botao_08;
        private Button botao_07;
        private Button botao_06;
        private Button botao_05;
        private Button botao_03;
        private Button botao_02;
        private Button botao_01;
        private Button botao_00;
        private Button botao_04;
        private Button botao_soma;
        private Button botao_subtração;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversãoToolStripMenuItem;
        private ToolStripMenuItem celsius_para_fahrenheit;
        private ToolStripMenuItem cmParaPolegadaToolStripMenuItem;
        private ToolStripMenuItem calculadora_sair;
    }
}