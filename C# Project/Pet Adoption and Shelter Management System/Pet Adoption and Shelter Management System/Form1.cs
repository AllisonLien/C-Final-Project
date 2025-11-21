using MySql.Data.MySqlClient;
using System.Data;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public partial class FormLogin : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            mySqlConnection = MYDB.Connect();

            try
            {
                mySqlConnection.Open();

                string sql = "SELECT * FROM users WHERE username=@u AND password=@p";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@u", TxtName.Text);
                cmd.Parameters.AddWithValue("@p", TxtPass.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string username = reader["username"].ToString();
                    string role = reader["role"].ToString();

                    MessageBox.Show("Login Sucessfully");
                    FormHome main = new FormHome(username, role);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password are wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            MYDB = new Database("localhost", "root", "admin", "petdb", "3306");

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
