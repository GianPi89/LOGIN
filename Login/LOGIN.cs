using Login;

namespace Prueba
{
    public partial class LOGIN : Form
    {
        private int intentos = 0;
        List<string> id = new List<string>();
        List<string> password = new List<string>();
        public LOGIN()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creado por: Gian Pierre Martinez Otero
        /// App Login para Registrarse e Inicio de Sesión
        /// </summary>
   
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
    
            if (txt_pass.Text == "CONTRASEÑA")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USUARIO";
                txt_user.ForeColor = Color.DimGray;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "CONTRASEÑA";
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar == false)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
            else if (txt_pass.UseSystemPasswordChar == true)
            {
                txt_pass.UseSystemPasswordChar = false;
            }

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            

            int cont = 0;
            string id_inicio = txt_user.Text;
            string password_inicio = txt_pass.Text;
            for (int i = 0; i < id.Count; i++)//Este Metodo se usa para iniciar Sesión Luego de Registrarse
            {
                if (id_inicio == id[i] && password_inicio == password[i])
                {
                    txt_pass.Text = "CONTRASEÑA";
                    txt_user.Text = "USUARIO";
                    txt_pass.UseSystemPasswordChar = false;
                    MessageBox.Show("Has iniciado sesión correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i = id.Count;
                    cont = 0;

                }
                else
                {
                    cont++;
                    
                }
            }
            if (cont != 0) // Aqui se analiza si los datos ingresados para iniciar Sesión son correctos
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            //Se valida el registro del Usuario

            id.Add(txt_user.Text);
            password.Add(txt_pass.Text);
            txt_pass.Text = "CONTRASEÑA";
            txt_user.Text = "USUARIO";
            txt_pass.UseSystemPasswordChar = false;
            MessageBox.Show("Te has registrado correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //este método se usa para cerrar programa
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            //Este método se usa para minimizar programa
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            //En este método solo permitimos que el usuario ingrese texto
            char c = e.KeyChar;

            if (!Char.IsLetter(c) && c != '\b')
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }
    }
}