namespace CLUB_DEPORTIVO
{
    partial class Frm1
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
            pbx1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Ingresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            SuspendLayout();
            // 
            // pbx1
            // 
            pbx1.Image = Properties.Resources.ESCUDO_CLUB;
            pbx1.Location = new Point(253, 12);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(272, 183);
            pbx1.SizeMode = PictureBoxSizeMode.Zoom;
            pbx1.TabIndex = 0;
            pbx1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 198);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 1;
            label1.Text = "INGRESE SU USUARIO Y CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 246);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "USUARIO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 297);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 294);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 5;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.Red;
            btn_Ingresar.ForeColor = Color.White;
            btn_Ingresar.Location = new Point(301, 356);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(192, 43);
            btn_Ingresar.TabIndex = 6;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += button1_Click;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Ingresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbx1);
            Name = "Frm1";
            Text = "ACCEDER AL SISTEMA";
            Load += Frm1_Load;
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Ingresar;
    }
}
