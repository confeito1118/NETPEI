using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPLE
{
    public partial class Form2 : Form
    {
        const string connectionString = "Data Source=DataBase.sqlite";

        public Form2()
        {
            InitializeComponent();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // トランザクション処理
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var ipaddress = IP.Text.ToString();

                        var sql = "UPDATE QFILE SET DATA = '" + ipaddress + "' WHERE NAME = 'IP'";
                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                connection.Close();
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // トランザクション処理
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var domain = DO.Text.ToString();

                        var sql = "UPDATE QFILE SET DATA = '" + domain + "' WHERE NAME = 'DO'";
                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                connection.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
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
                            IP.Text = data2;
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }

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
                            DO.Text = data2;
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }
        }
    }
}
