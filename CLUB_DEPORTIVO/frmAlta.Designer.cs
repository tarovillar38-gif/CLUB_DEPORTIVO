namespace CLUB_DEPORTIVO
{
    partial class frmAltaSocios
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
            pbx1 = new PictureBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            SuspendLayout();
            // 
            // pbx1
            // 
            pbx1.Image = Properties.Resources.ESCUDO_CLUB;
            pbx1.Location = new Point(263, 12);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(272, 183);
            pbx1.SizeMode = PictureBoxSizeMode.Zoom;
            pbx1.TabIndex = 2;
            pbx1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 207);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 3;
            label1.Text = "INGRESE LOS DATOS DEL SOLICITANTE";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(312, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "SOCIO";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(390, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "NO SOCIO";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 280);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 310);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 341);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "DOCUMENTO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 23);
            textBox3.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(199, 382);
            button1.Name = "button1";
            button1.Size = new Size(127, 28);
            button1.TabIndex = 12;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(349, 382);
            button2.Name = "button2";
            button2.Size = new Size(122, 28);
            button2.TabIndex = 13;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(489, 382);
            button3.Name = "button3";
            button3.Size = new Size(122, 28);
            button3.TabIndex = 14;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = false;
            // 
            // frmAltaSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(pbx1);
            Name = "frmAltaSocios";
            Text = "ALTA SOCIO/NO SOCIO";
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}