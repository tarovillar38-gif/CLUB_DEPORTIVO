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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
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
            label1.Location = new Point(283, 208);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 1;
            label1.Text = "INGRESE SU USUARIO Y CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 246);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "USUARIO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 283);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(269, 238);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(244, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(269, 280);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(241, 23);
            txtContrasena.TabIndex = 7;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Lime;
            btnIngresar.Location = new Point(302, 339);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(172, 35);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
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
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;
    }
}
