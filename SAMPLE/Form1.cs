using System.Data.Common;
using System.Data.SQLite;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAMPLE
{
    public partial class Form1 : Form
    {
        const string connectionString = "Data Source=DataBase.sqlite";

        public Form1()
        {
            InitializeComponent();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            // Form2�̃C���X�^���X�𐶐�
            Form2 form2 = new Form2();
            // form2��\��
            form2.Show();
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                // �ڑ�����w��
                using (var conn = new SQLiteConnection(connectionString))
                using (var command = conn.CreateCommand())
                {
                    // �ڑ�
                    conn.Open();

                    // �R�}���h�̎��s����
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"�X�V���ꂽ���R�[�h���� {value} �ł��B");
                }
            }
            catch (Exception ex)
            {
                //��O�������������̓��b�Z�[�W�{�b�N�X��\��
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertRecord(string name, string data)
        {
            // ���R�[�h�̓o�^
            var query = "INSERT INTO QFILE (NAME, DATA) VALUES (" +
                $"'{name}', '{data}')";

            // �N�G���[���s
            ExecuteNonQuery(query.ToString());
        }

        private void qfileIP_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var sql = "SELECT * FROM QFILE WHERE NAME = 'IP'";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var data1 = (string)reader["NAME"];
                            var data2 = (string)reader["DATA"];

                            ipaddress.Text = data2;
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }

            System.Diagnostics.Process.Start("explorer.exe", @"\\" + ipaddress.Text.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"./start.txt";
            if (System.IO.File.Exists(fileName))
            {
                // MessageBox.Show("'" + fileName + "' �Z�b�g�A�b�v�E�B�U�[�h�͑��݂��܂��B");
            } else {
                // �e�[�u���������݂��Ȃ���΍쐬����
                StringBuilder query = new StringBuilder();
                query.Clear();
                query.Append("CREATE TABLE IF NOT EXISTS QFILE (");
                query.Append(" NO INTEGER PRIMARY KEY AUTOINCREMENT");
                query.Append(" ,NAME TEXT NOT NULL");
                query.Append(" ,DATA TEXT NOT NULL");
                //query.Append(" ,primary key (NO)");
                query.Append(")");

                // �N�G���[���s
                ExecuteNonQuery(query.ToString());

                InsertRecord("IP", "192.168.100.250");
                InsertRecord("DO", "NAS303F9E");

                using (FileStream fs = File.Create(fileName));
            }
        }

        private void qfileDO_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var sql = "SELECT * FROM QFILE WHERE NAME = 'DO'";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var data1 = (string)reader["NAME"];
                            var data2 = (string)reader["DATA"];

                            domain.Text = data2;
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }

            System.Diagnostics.Process.Start("explorer.exe", @"\\" + domain.Text.ToString());
        }
    }
}
