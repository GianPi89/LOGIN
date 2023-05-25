namespace Prueba
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txt_user = new TextBox();
            label1 = new Label();
            txt_pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Btn_Ingresar = new Button();
            Btn_Registro = new Button();
            label4 = new Label();
            Btn_VerContraseña = new PictureBox();
            BtnSalir = new PictureBox();
            BtnMinimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_VerContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.FromArgb(15, 15, 15);
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = Color.DimGray;
            txt_user.Location = new Point(331, 80);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(316, 20);
            txt_user.TabIndex = 1;
            txt_user.Text = "USUARIO";
            txt_user.Enter += txt_user_Enter;
            txt_user.KeyPress += txt_user_KeyPress;
            txt_user.Leave += txt_user_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(331, 94);
            label1.Name = "label1";
            label1.Size = new Size(362, 15);
            label1.TabIndex = 2;
            label1.Text = "_______________________________________________________________________";
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(15, 15, 15);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = Color.DimGray;
            txt_pass.Location = new Point(331, 147);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(316, 20);
            txt_pass.TabIndex = 3;
            txt_pass.Text = "CONTRASEÑA";
            txt_pass.Enter += txt_pass_Enter;
            txt_pass.Leave += txt_pass_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(331, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(481, 9);
            label3.Name = "label3";
            label3.Size = new Size(100, 33);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // Btn_Ingresar
            // 
            Btn_Ingresar.BackColor = Color.FromArgb(40, 40, 40);
            Btn_Ingresar.FlatAppearance.BorderSize = 0;
            Btn_Ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Btn_Ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_Ingresar.FlatStyle = FlatStyle.Flat;
            Btn_Ingresar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Ingresar.ForeColor = Color.Gainsboro;
            Btn_Ingresar.Location = new Point(344, 253);
            Btn_Ingresar.Name = "Btn_Ingresar";
            Btn_Ingresar.Size = new Size(150, 30);
            Btn_Ingresar.TabIndex = 0;
            Btn_Ingresar.Text = "INGRESAR";
            Btn_Ingresar.UseVisualStyleBackColor = false;
            Btn_Ingresar.Click += Btn_Ingresar_Click;
            // 
            // Btn_Registro
            // 
            Btn_Registro.BackColor = Color.FromArgb(40, 40, 40);
            Btn_Registro.FlatAppearance.BorderSize = 0;
            Btn_Registro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Btn_Registro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_Registro.FlatStyle = FlatStyle.Flat;
            Btn_Registro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Registro.ForeColor = Color.Gainsboro;
            Btn_Registro.Location = new Point(533, 253);
            Btn_Registro.Name = "Btn_Registro";
            Btn_Registro.Size = new Size(150, 30);
            Btn_Registro.TabIndex = 7;
            Btn_Registro.Text = "REGISTRARSE";
            Btn_Registro.UseVisualStyleBackColor = false;
            Btn_Registro.Click += Btn_Registro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(331, 161);
            label4.Name = "label4";
            label4.Size = new Size(362, 15);
            label4.TabIndex = 8;
            label4.Text = "_______________________________________________________________________";
            // 
            // Btn_VerContraseña
            // 
            Btn_VerContraseña.Cursor = Cursors.Hand;
            Btn_VerContraseña.Image = (Image)resources.GetObject("Btn_VerContraseña.Image");
            Btn_VerContraseña.Location = new Point(699, 147);
            Btn_VerContraseña.Name = "Btn_VerContraseña";
            Btn_VerContraseña.Size = new Size(27, 29);
            Btn_VerContraseña.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_VerContraseña.TabIndex = 9;
            Btn_VerContraseña.TabStop = false;
            Btn_VerContraseña.Click += pictureBox2_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(756, 0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(23, 27);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 10;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(736, 0);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(23, 27);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 11;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(BtnSalir);
            Controls.Add(BtnMinimizar);
            Controls.Add(Btn_VerContraseña);
            Controls.Add(Btn_Registro);
            Controls.Add(Btn_Ingresar);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LOGIN";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Ventas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_VerContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txt_user;
        private Label label1;
        private TextBox txt_pass;
        private Label label2;
        private Label label3;
        private Button Btn_Ingresar;
        private Button Btn_Registro;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox Btn_VerContraseña;
        private PictureBox BtnSalir;
        private PictureBox BtnMinimizar;
    }
}