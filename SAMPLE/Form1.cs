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
                // 接続先を指定
                using (var conn = new SQLiteConnection(connectionString))
                using (var command = conn.CreateCommand())
                {
                    // 接続
                    conn.Open();

                    // コマンドの実行処理
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"更新されたレコード数は {value} です。");
                }
            }
            catch (Exception ex)
            {
                //例外が発生した時はメッセージボックスを表示
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertRecord(string name, string data)
        {
            // レコードの登録
            var query = "INSERT INTO QFILE (NAME, DATA) VALUES (" +
                $"'{name}', '{data}')";

            // クエリー実行
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
                // MessageBox.Show("'" + fileName + "' セットアップウィザードは存在します。");
            }
            else
            {
                // テーブル名が存在しなければ作成する
                StringBuilder query = new StringBuilder();
                query.Clear();
                query.Append("CREATE TABLE IF NOT EXISTS QFILE (");
                query.Append(" NO INTEGER PRIMARY KEY AUTOINCREMENT");
                query.Append(" ,NAME TEXT NOT NULL");
                query.Append(" ,DATA TEXT NOT NULL");
                //query.Append(" ,primary key (NO)");
                query.Append(")");

                // クエリー実行
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
            //Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            //コマンドラインを指定（"/c"は実行後閉じるために必要）
            p.StartInfo.Arguments = @"/c " + command;

            //起動
            p.Start();

            //出力を読み取る
            string results = p.StandardOutput.ReadToEnd();

            //プロセス終了まで待機する
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();
            p.Close();

            //出力された結果を表示
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

        // 設定画面の表示
        public void openSettingScreen()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        // net use コマンドによるセッションの接続確認
        public void sessionCheck()
        {
            string result = cmdRun("net use");
            uxCommand.Text = result;
        }

        private void sessCheckCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionCheck();
        }

        // net use コマンドによるセッションの接続削除
        public void sessionDelete()
        {
            string result = cmdRun("net use * /delete /y");
            uxCommand.Text = result;
        }

        private void sessDeleteEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionDelete();
        }

        // パソコンの再起動
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
