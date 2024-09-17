namespace Calculadora
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(165, 302);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 50);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 364);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 1;
            label1.Text = "Loading...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.monkey_14540_256;
            pictureBox1.Location = new Point(80, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 140);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing1;
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(788, 462);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.beach_7183_256;
            pictureBox3.Location = new Point(584, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 461);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
    }
}
