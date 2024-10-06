namespace Calculadora
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            convert_celsius = new TextBox();
            Fahrenheit = new TextBox();
            converter = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura em Celcius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 1;
            label2.Text = "Temperatura em Fahrenheit";
            // 
            // convert_celsius
            // 
            convert_celsius.Location = new Point(23, 58);
            convert_celsius.Name = "convert_celsius";
            convert_celsius.Size = new Size(134, 23);
            convert_celsius.TabIndex = 2;
            // 
            // Fahrenheit
            // 
            Fahrenheit.Location = new Point(23, 157);
            Fahrenheit.Name = "Fahrenheit";
            Fahrenheit.Size = new Size(152, 23);
            Fahrenheit.TabIndex = 3;
            // 
            // converter
            // 
            converter.Location = new Point(226, 58);
            converter.Name = "converter";
            converter.Size = new Size(75, 23);
            converter.TabIndex = 4;
            converter.Text = "Converter";
            converter.UseVisualStyleBackColor = true;
            converter.Click += converter_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 122);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 207);
            Controls.Add(button2);
            Controls.Add(converter);
            Controls.Add(Fahrenheit);
            Controls.Add(convert_celsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox convert_celsius;
        private TextBox Fahrenheit;
        private Button converter;
        private Button button2;
    }
}