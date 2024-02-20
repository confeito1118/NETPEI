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
                // 接続先を指定
                using (var conn = new SQLiteConnection("Data Source=DataBase.sqlite"))
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
            var query = "INSERT INTO PURCHASELIST (NAME, DATA) VALUES (" +
                $"'{name}', '{data}')";

            // クエリー実行
            ExecuteNonQuery(query.ToString());
        }

        private void qfileIP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\192.168.100.250");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // テーブル名が存在しなければ作成する
            StringBuilder query = new StringBuilder();
            query.Clear();
            query.Append("CREATE TABLE IF NOT EXISTS PURCHASELIST (");
            query.Append(" NO INTEGER PRIMARY KEY AUTOINCREMENT");
            query.Append(" ,NAME TEXT NOT NULL");
            query.Append(" ,DATA TEXT NOT NULL");
            //query.Append(" ,primary key (NO)");
            query.Append(")");

            // クエリー実行
            ExecuteNonQuery(query.ToString());

            InsertRecord("IP", "192.168.100.250");
            InsertRecord("DO", "NAFW25");
        }
    }
}
