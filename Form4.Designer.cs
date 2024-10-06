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
            button2.Location = new Point(232, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // converter
            // 
            converter.Location = new Point(232, 62);
            converter.Name = "converter";
            converter.Size = new Size(75, 23);
            converter.TabIndex = 10;
            converter.Text = "Converter";
            converter.UseVisualStyleBackColor = true;
            converter.Click += converter_Click;
            // 
            // polegadas
            // 
            polegadas.Location = new Point(29, 161);
            polegadas.Name = "polegadas";
            polegadas.Size = new Size(152, 23);
            polegadas.TabIndex = 9;
            // 
            // centimetros
            // 
            centimetros.Location = new Point(29, 62);
            centimetros.Name = "centimetros";
            centimetros.Size = new Size(134, 23);
            centimetros.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Polegadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 6;
            label1.Text = "Centímetros";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Text = "Form4";
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