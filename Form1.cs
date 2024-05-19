using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Аптека.Form1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class UserManager
        {
            private string connectionString = "Data Source=DESKTOP-JC5A2Q8\\SQLEXPRESS;Initial Catalog= Аптека;Integrated Security=True";
                public bool AuthenticateUser(string username, string password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM P_and_L WHERE Login  = @Login AND Passworsd = @Passworsd";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Passworsd", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = PasswordTextBox.Text;

            UserManager userManager = new UserManager();
            if (userManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вы успешно вошли в систему");
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!");
            }
        }
    }
}
