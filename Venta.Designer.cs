namespace MarketSystem
{
    partial class Venta
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
            label4 = new Label();
            textBox3 = new TextBox();
            button5 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button2.BackColor = Color.MediumPurple;
            button2.Location = new Point(715, 58);
            button2.Name = "button2";
            button2.Size = new Size(438, 191);
            button2.TabIndex = 1;
            button2.Text = "Venta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(1234, 58);
            button3.Name = "button3";
            button3.Size = new Size(438, 191);
            button3.TabIndex = 2;
            button3.Text = "Reporte";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(181, 314);
            panel1.Name = "panel1";
            panel1.Size = new Size(1491, 739);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 587);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 18;
            label4.Text = "Pago con:";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(799, 624);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 17;
            textBox3.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(89, 544);
            button5.Name = "button5";
            button5.Size = new Size(349, 138);
            button5.TabIndex = 16;
            button5.Text = "Facturar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(819, 491);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 11;
            label6.Text = "Cantidad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(799, 534);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(627, 623);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 7;
            label3.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(604, 578);
            label2.Name = "label2";
            label2.Size = new Size(126, 36);
            label2.TabIndex = 6;
            label2.Text = "Sub Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 491);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 5;
            label1.Text = "Producto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 534);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(1077, 517);
            button4.Name = "button4";
            button4.Size = new Size(349, 165);
            button4.TabIndex = 1;
            button4.Text = "Agregar Poducto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1086, 412);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.b1b48e3cdd0036ef98bf0af1460d7898_icono_de_producto_de_limpieza;
            pictureBox1.Location = new Point(200, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumPurple;
            pictureBox2.Image = Properties.Resources._2331680;
            pictureBox2.Location = new Point(757, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveBorder;
            pictureBox3.Image = Properties.Resources._3094836;
            pictureBox3.Location = new Point(1267, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Venta
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
            Name = "Venta";
            Text = "MarketSystem";
            WindowState = FormWindowState.Maximized;
            Load += Venta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox textBox2;
        private Button button5;
        private Label label4;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}