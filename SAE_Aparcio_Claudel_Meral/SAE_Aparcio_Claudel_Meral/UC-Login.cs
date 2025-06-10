using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UC_GestionPerso
{
    public delegate void LoginResultDelegate(bool success);
    public delegate void LoginCancelledDelegate();
    public partial class UCLogin : UserControl
    {
        SQLiteConnection m_con;
        private bool _connected;

        public bool Connected
        {
            get { return _connected; }
            set
            {
                _connected = value;
                if(!_connected)
                {
                    txtUser.Clear();
                    txtPwd.Clear();
                    txtUser.Focus();
                }
            }
        }

        public LoginResultDelegate OnLoginResult;
        public LoginCancelledDelegate OnLoginCancelled;

        public UCLogin()
        {
            InitializeComponent();
            txtPwd.UseSystemPasswordChar = true;
            btnValider.Click += btnValider_Click; // Assure que le handler est attaché
        }

        public UCLogin(SQLiteConnection con) : this()
        {
            m_con = con;
            if(m_con.State == ConnectionState.Closed)
            {
                m_con.Open();
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtPwd.UseSystemPasswordChar = !txtPwd.UseSystemPasswordChar;
        }

        private void ValidateLogin()
        {
            try
            {
                if(m_con == null || m_con.State != ConnectionState.Open)
                {
                    MessageBox.Show("Erreur de connexion à la base de données");
                    OnLoginResult?.Invoke(false);
                    return;
                }

                string login = txtUser.Text.Trim();
                string mdp = txtPwd.Text;

                if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdp))
                {
                    MessageBox.Show("Veuillez saisir un identifiant et un mot de passe");
                    OnLoginResult?.Invoke(false);
                    return;
                }

                string command = "SELECT mdp FROM Admin WHERE login = @login;";
                using(SQLiteCommand cmd = new SQLiteCommand(command, m_con))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    object result = cmd.ExecuteScalar();

                    if(result == null)
                    {
                        MessageBox.Show("Identifiant incorrect");
                        OnLoginResult?.Invoke(false);
                        return;
                    }

                    string storedPassword = result.ToString();
                    if(mdp == storedPassword)
                    {
                        _connected = true;
                        OnLoginResult?.Invoke(true);
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                        OnLoginResult?.Invoke(false);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion: {ex.Message}");
                OnLoginResult?.Invoke(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaaaaaaaa");
            OnLoginCancelled.Invoke();  
            this.Visible = false;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(sender == txtUser)
                {
                    txtPwd.Focus();
                }
                else if(sender == txtPwd)
                {
                    ValidateLogin();
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }
    }
}
