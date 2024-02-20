using System.Data.SQLite;
using System.Text;

namespace SAMPLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setting_Click(object sender, EventArgs e)
        {



        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                // �ڑ�����w��
                using (var conn = new SQLiteConnection("Data Source=DataBase.sqlite"))
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
            var query = "INSERT INTO PURCHASELIST (NAME, DATA) VALUES (" +
                $"'{name}', '{data}')";

            // �N�G���[���s
            ExecuteNonQuery(query.ToString());
        }

        private void qfileIP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\192.168.100.250");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �e�[�u���������݂��Ȃ���΍쐬����
            StringBuilder query = new StringBuilder();
            query.Clear();
            query.Append("CREATE TABLE IF NOT EXISTS PURCHASELIST (");
            query.Append(" NO INTEGER PRIMARY KEY AUTOINCREMENT");
            query.Append(" ,NAME TEXT NOT NULL");
            query.Append(" ,DATA TEXT NOT NULL");
            //query.Append(" ,primary key (NO)");
            query.Append(")");

            // �N�G���[���s
            ExecuteNonQuery(query.ToString());

            InsertRecord("IP", "192.168.100.250");
            InsertRecord("DO", "NAFW25");
        }
    }
}
