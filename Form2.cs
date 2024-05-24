using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Аптека
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }




        private string connectionString = "Data Source=DESKTOP-JC5A2Q8\\SQLEXPRESS;Initial Catalog= Аптека;Integrated Security=True";

        private void Form2_Load(object sender, EventArgs e)//загружаются данные в различные таблицы из базы данных.
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet7.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter2.Fill(this.аптекаDataSet7.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet6.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter1.Fill(this.аптекаDataSet6.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet5.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.аптекаDataSet5.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet2.Madication". При необходимости она может быть перемещена или удалена.
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);

        }
        private void AddButton_Click(object sender, EventArgs e)//добавляет новую строку в таблицу Madication, после проверки заполнения всех текстовых полей.
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все три текстовых поля.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX(id_Mtion) FROM Madication", connection);
                int lastId = Convert.ToInt32(command.ExecuteScalar());

                command = new SqlCommand("INSERT INTO Madication (id_Mtion, Name_of_the_drug,The_amount_of_the_drug, Country_of_the_drug, The_prise_of_the_drug) VALUES (@id_Mtion, @Name_of_the_drug, @The_amount_of_the_drug, @Country_of_the_drug, @The_prise_of_the_drug)", connection);

//Изменены названия обектов textBox
                command.Parameters.AddWithValue("@id_Mtion", lastId + 1);
                command.Parameters.AddWithValue("@Name_of_the_drug", textBoxNameID.Text);
                command.Parameters.AddWithValue("@The_amount_of_the_drug", textBoxAmount.Text);
                command.Parameters.AddWithValue("@Country_of_the_drug", (textBoxCountry.Text));
                command.Parameters.AddWithValue("@The_prise_of_the_drug", (textBoxPrise.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Новая строка добавлена в базу данных.");
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все текстовые поля.");
                return;
            }
            int id_Mtion = Convert.ToInt32(textBox4.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Madication SET Name_of_the_drug=@Name,The_amount_of_the_drug=@amount, Country_of_the_drug=@Country, The_prise_of_the_drug=@Price WHERE id_Mtion = @id", connection);
                command.Parameters.AddWithValue("@id_Mtion", int.Parse(textBox4.Text));
                command.Parameters.AddWithValue("@Country_of_the_drug", id_Mtion);
                command.Parameters.AddWithValue("@The_prise_of_the_drug", (textBox4.Text));
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Строка успешно обновлена в базе данных.");
                }
                else
                {
                    MessageBox.Show("Не удалось найти строку с указанным Id.");
                }
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Пожалуйста, введите Id строки для удаления.");
                return;
            }

            int id = Convert.ToInt32(textBox4.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Madication WHERE id_Mtion = @id_Mtion", connection);
                command.Parameters.AddWithValue("@id_Mtion", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Строка успешно удалена из базы данных.");
                }
                else
                {
                    MessageBox.Show("Не удалось найти строку с указанным Id.");
                }
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
