namespace MarketSystem
{
    partial class Reporte
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(181, 58);
            button1.Name = "button1";
            button1.Size = new Size(438, 191);
            button1.TabIndex = 0;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(715, 58);
            button2.Name = "button2";
            button2.Size = new Size(438, 191);
            button2.TabIndex = 1;
            button2.Text = "Venta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.Location = new Point(1234, 58);
            button3.Name = "button3";
            button3.Size = new Size(438, 191);
            button3.TabIndex = 2;
            button3.Text = "Reporte";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(181, 314);
            panel1.Name = "panel1";
            panel1.Size = new Size(1491, 739);
            panel1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(784, 80);
            button5.Name = "button5";
            button5.Size = new Size(402, 53);
            button5.TabIndex = 19;
            button5.Text = "Reporte de ventas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(259, 80);
            button4.Name = "button4";
            button4.Size = new Size(402, 53);
            button4.TabIndex = 18;
            button4.Text = "Reporte de producto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 208);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1316, 448);
            textBox4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.b1b48e3cdd0036ef98bf0af1460d7898_icono_de_producto_de_limpieza;
            pictureBox1.Location = new Point(203, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Image = Properties.Resources._2331680;
            pictureBox2.Location = new Point(751, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MediumPurple;
            pictureBox3.Image = Properties.Resources._3094836;
            pictureBox3.Location = new Point(1262, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1783, 1134);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Reporte";
            Text = "MarketSystem";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}