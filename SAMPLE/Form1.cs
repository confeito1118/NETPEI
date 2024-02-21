using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
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
            openSettingScreen();
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
            connectionIP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"./start.txt";
            if (System.IO.File.Exists(fileName))
            {
                // MessageBox.Show("'" + fileName + "' �Z�b�g�A�b�v�E�B�U�[�h�͑��݂��܂��B");
            }
            else
            {
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

                using (FileStream fs = File.Create(fileName)) ;
            }
        }

        private void qfileDO_Click(object sender, EventArgs e)
        {
            connectionDO();
        }

        private void sessCheck_Click(object sender, EventArgs e)
        {
            sessionCheck();
        }

        static string cmdRun(string command)
        {
            //Process�I�u�W�F�N�g���쐬
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            //ComSpec(cmd.exe)�̃p�X���擾���āAFileName�v���p�e�B�Ɏw��
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //�o�͂�ǂݎ���悤�ɂ���
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            //�E�B���h�E��\�����Ȃ��悤�ɂ���
            p.StartInfo.CreateNoWindow = true;
            //�R�}���h���C�����w��i"/c"�͎��s����邽�߂ɕK�v�j
            p.StartInfo.Arguments = @"/c " + command;

            //�N��
            p.Start();

            //�o�͂�ǂݎ��
            string results = p.StandardOutput.ReadToEnd();

            //�v���Z�X�I���܂őҋ@����
            //WaitForExit��ReadToEnd�̌�ł���K�v������
            //(�e�v���Z�X�A�q�v���Z�X�Ńu���b�N�h�~�̂���)
            p.WaitForExit();
            p.Close();

            //�o�͂��ꂽ���ʂ�\��
            return results;
        }

        private void sessDelete_Click(object sender, EventArgs e)
        {
            sessionDelete();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            pcReboot();
        }

        private void SettingSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSettingScreen();
        }

        // �ݒ��ʂ̕\��
        public void openSettingScreen()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        // net use �R�}���h�ɂ��Z�b�V�����̐ڑ��m�F
        public void sessionCheck()
        {
            string result = cmdRun("net use");
            uxCommand.Text = result;
        }

        private void sessCheckCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionCheck();
        }

        // net use �R�}���h�ɂ��Z�b�V�����̐ڑ��폜
        public void sessionDelete()
        {
            string result = cmdRun("net use * /delete /y");
            uxCommand.Text = result;
        }

        private void sessDeleteEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionDelete();
        }

        // �p�\�R���̍ċN��
        public void pcReboot()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "shutdown.exe";
                // psi.Arguments = "-s -t 0";   // shutdown
                psi.Arguments = "-r -t 0";   // reboot
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void pcRebootRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pcReboot();
        }

        private void closeWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnIPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionIP();
        }

        private void cnDODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionDO();
        }

        public void connectionDO()
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

        public void connectionIP()
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

        private void versionVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
