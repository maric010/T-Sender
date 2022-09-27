using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Telegram
{
    public partial class Form1 : Form
    {
        internal static Form1 th;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skyLabel1.Text = my.firstname + " " + my.lastname;
            skyLabel2.Text = my.email;
            dungeonHeaderLabel1.Text = "Тарифный план: "+my.tarif.Split(":")[0];
            metroEllipse1.Text = my.firstname.First().ToString();
            th = this;
            foxButton3_Click(null, null);
        }

        
        internal static void load_form(Form f)
        {
            // Функция которая меняет формы внутри основной формы
            th.panel1.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            th.panel1.Controls.Add(f);
            th.panel1.Tag = f;
            f.Show();
        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel5.Visible)
                panel5.Visible = false;
            else
                panel5.Visible = true;
        }

        

        private void IMGPAINT(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(((TButton)sender).Image, 15, 12, 22, 22);
        }

        

        public void tButton6_Click(object sender, EventArgs e)
        {
            //Переход на вкладку новой рассылки
            load_form(new Send());
            panel11.Visible = false;
            tButton1.Enabled = true;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = true;
            tButton6.Enabled = false;
            foxButton2.Enabled = true;
            foxButton4.Enabled = true;
            foxButton3.Enabled = true;
            if (panel5.Visible)
                panel5.Visible = false;

        }
        private void foxButton2_Click(object sender, EventArgs e)
        {
            //Переход во вкладку мои рассылки
            if (my.Mails.Count == 0)
                load_form(new My_mails2());
            else
                load_form(new My_mails3());
            panel11.Visible = false;
            tButton1.Enabled = true;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = true;
            panel7.Visible = false;
            foxButton2.Enabled = false;
            foxButton3.Enabled = true;
            tButton6.Enabled = true;
            foxButton4.Enabled = true;
            if (panel5.Visible)
                panel5.Visible = false;
        }



        private void foxButton3_Click(object sender, EventArgs e)
        {
            //Переход во вкладку мои аккаунты
            load_form(new Accounts());
            panel11.Visible = false;
            tButton1.Enabled = true;
            panel10.Visible = true;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            foxButton3.Enabled = false;
            foxButton2.Enabled = true;
            tButton6.Enabled = true;
            foxButton4.Enabled = true;
            if (panel5.Visible)
                panel5.Visible = false;
        }
        private void foxButton4_Click(object sender, EventArgs e)
        {
            //Переход во вкладку парсинг групп
            load_form(new Parse());
            panel10.Visible = false;
            panel9.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel11.Visible = false;
            tButton1.Enabled = true;
            foxButton4.Enabled = false;
            foxButton3.Enabled = true;
            foxButton2.Enabled = true;
            tButton6.Enabled = true;
            if (panel5.Visible)
                panel5.Visible = false;
        }
        private void tButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выйти из аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        

        private void tButton3_Click(object sender, EventArgs e)
        {
            tButton1_Click(sender, e);
        }

        private void tButton2_Click(object sender, EventArgs e)
        {
            load_form(new cabinet());
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            tButton1.Enabled = true;
            foxButton3.Enabled = true;
            foxButton2.Enabled = true;
            tButton6.Enabled = true;
            foxButton4.Enabled = true;
        }

        private void metroEllipse1_Click(object sender, EventArgs e)
        {
            //показать или скрыть меню
            if (panel5.Visible)
                panel5.Visible = false;
            else
                panel5.Visible = true;
        }

        

        private void skyLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void skyLabel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void IMGPAINT3(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(((TButton)sender).Image, 15, 7, 22, 22);
        }

        private void IMGPAINT4(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(((TButton)sender).Image, 13, 7, 22, 22);
        }

        private void IMGPAINT5(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(((TButton)sender).Image, 16, 7, 22, 22);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (panel5.Visible)
                panel5.Visible = false;
        }

        private void tButton1_Click(object sender, EventArgs e)
        {
            load_form(new Тех_Поддержка());
            panel11.Visible = true;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            tButton1.Enabled = false;
            foxButton3.Enabled = true;
            foxButton2.Enabled = true;
            tButton6.Enabled = true;
            foxButton4.Enabled = true;

        }

        private void tButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel5.Visible)
                panel5.Visible = false;
        }

        private void IMGPAINT6(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(((TButton)sender).Image, 13, (((TButton)sender).Height/2)-12, 22, 22);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}