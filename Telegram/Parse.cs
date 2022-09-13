namespace Telegram
{
    public partial class Parse : Form
    {
        internal static Parse th;
        public Parse()
        {
            InitializeComponent();
            th = this;
        }

        private void dungeonButtonLeft1_Click(object sender, EventArgs e)
        {
            //Откроется диалоговое окно для сохранения файла контактов
            saveFileDialog1.FileName = dungeonTextBox1.Text+".xlsx";
            saveFileDialog1.Filter = "Xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                my.save_file_path = saveFileDialog1.FileName;
                server.send("start_parse|" + dungeonTextBox1.Text);
            }
            
        }
    }
}
