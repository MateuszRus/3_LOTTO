using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _3_LOTTO
{
    public partial class DuzyLotek : Form
    {
        private string connectionString = "Data Source='KOMP';"
            + "Integrated Security=True;Pooling=False;Initial Catalog='WYNIKI'";

        private SqlConnection connection;

        public DuzyLotek()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            Load();
        }

        private void Load()
        {
            dataGridViewDuzy.Rows.Clear();
            string sql = "SELECT DateOfDraw, Number1, Number2, Number3, Number4, Number5, Number6 FROM LOTTO";

            connection.Open();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataGridViewDuzy.Rows.Add(reader[0].ToString().Substring(0, 10), reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }

            reader.Close();
            connection.Close();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            FormAdd fd = new FormAdd();
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                connection.Open();
                string sql = "INSERT INTO LOTTO VALUES (@DateOfDraw, @Number1, @Number2, @Number3, @Number4, @Number5, @Number6);";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@DateOfDraw", Convert.ToDateTime(fd.Data));
                command.Parameters.AddWithValue("@Number1", fd.Liczba1);
                command.Parameters.AddWithValue("@Number2", fd.Liczba2);
                command.Parameters.AddWithValue("@Number3", fd.Liczba3);
                command.Parameters.AddWithValue("@Number4", fd.Liczba4);
                command.Parameters.AddWithValue("@Number5", fd.Liczba5);
                command.Parameters.AddWithValue("@Number6", fd.Liczba6);

                command.ExecuteNonQuery();
                connection.Close();
                Load();

                MessageBox.Show("Dodano wynik losowania!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

