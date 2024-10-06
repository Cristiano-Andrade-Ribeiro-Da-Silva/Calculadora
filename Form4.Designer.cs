namespace Calculadora
{
    partial class Form4
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
            button2 = new Button();
            converter = new Button();
            polegadas = new TextBox();
            centimetros = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Location = new Point(232, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // converter
            // 
            converter.BackColor = Color.DarkGreen;
            converter.FlatStyle = FlatStyle.Popup;
            converter.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            converter.ForeColor = Color.White;
            converter.Location = new Point(232, 62);
            converter.Name = "converter";
            converter.Size = new Size(75, 23);
            converter.TabIndex = 10;
            converter.Text = "Converter";
            converter.UseVisualStyleBackColor = false;
            converter.Click += converter_Click;
            // 
            // polegadas
            // 
            polegadas.BackColor = Color.DarkGreen;
            polegadas.BorderStyle = BorderStyle.FixedSingle;
            polegadas.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            polegadas.ForeColor = Color.White;
            polegadas.Location = new Point(29, 161);
            polegadas.Name = "polegadas";
            polegadas.Size = new Size(152, 22);
            polegadas.TabIndex = 9;
            // 
            // centimetros
            // 
            centimetros.BackColor = Color.DarkGreen;
            centimetros.BorderStyle = BorderStyle.FixedSingle;
            centimetros.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            centimetros.ForeColor = Color.White;
            centimetros.Location = new Point(29, 62);
            centimetros.Name = "centimetros";
            centimetros.Size = new Size(134, 22);
            centimetros.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 7;
            label2.Text = "Polegadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 6;
            label1.Text = "Centímetros";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(337, 207);
            Controls.Add(button2);
            Controls.Add(converter);
            Controls.Add(polegadas);
            Controls.Add(centimetros);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button converter;
        private TextBox polegadas;
        private TextBox centimetros;
        private Label label2;
        private Label label1;
    }
}