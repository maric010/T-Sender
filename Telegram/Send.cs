using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    public partial class Send : Form
    {
        internal static Send th;
        public Send()
        {
            InitializeComponent();
            th = this;
            //Сохраненную введенную информацию заполняет. 
            if(my.получатели_файл!=null && my.получатели_файл!="")
                dungeonTextBox2.Text = my.получатели_файл;
            
            dungeonLabel1.Text = "Загружено " + my.получатели_количество + " контактов";
            dungeonTextBox1.Text = my.получатели_текст;
            
            hopeRadioButton1.Checked = my.type_message;
            hopeRadioButton2.Checked = !my.type_message;
            
            if (my.media == 0)
            {
                hopeRadioButton4.Checked = true;
            }
            else if(my.media == 1)
            {
                hopeRadioButton3.Checked = true;
            }
            else if(my.media==2)
            {
                hopeRadioButton5.Checked = true;
            }
            else if(my.media==3)
            {
                hopeRadioButton8.Checked = true;
            }
            
            
            hopeRadioButton7.Checked= my.is_text;
            hopeRadioButton6.Checked = !my.is_text;
            if (my.is_text)
                tPanel1.Visible = true;
            else
                tPanel1.Visible = false;

            dungeonTextBox1.Text = my.получатели_текст;
            for(int i = 0; i < my.accounts.Count; i++)
            {
                if(my.accounts[i].status!="busy" || my.accounts[i].status != "flood")
                {
                    Grid_Select g = new Grid_Select();
                    g.account = my.accounts[i];
                    g.init_account();
                    flowLayoutPanel1.Controls.Add(g);
                }
                    
            }
            is_text(null, null);
            dungeonTextBox1_TextChanged(null, null);
            
        }
        internal static void load_media(Form f)
        {
            th.panel3.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            th.panel3.Controls.Add(f);
            th.panel3.Tag = f;
            f.Show();
        }
        private void Send_Click(object sender, EventArgs e)
        {
        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Откроется диалоговое окно для выбора файла контактов
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dungeonTextBox2.Text = openFileDialog1.FileName;
                    var worksheet = Workbook.Worksheets(dungeonTextBox2.Text).First();
                    var message = "";
                    int i = 0;
                    foreach (var row in worksheet.Rows)
                    {
                        string id="",username="",phone="",name="";
                        if (row.Cells[0] != null)
                            id = row.Cells[0].Text.ToString();
                        if (row.Cells[1] != null)
                            username = row.Cells[1].Text.ToString();
                        try
                        {
                            if (row.Cells[4] != null)
                                phone = row.Cells[4].Text.ToString();
                        }
                        catch
                        {

                        }
                        

                        message += id + "/"+ username+"/"+ phone+"&&";
                        i += 1;
                    }
                    my.получатели_количество = i;
                    dungeonLabel1.Text = "Загружено "+i+" контактов";
                    my.получатели = message;
                    my.получатели_файл = dungeonTextBox2.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                }
            }
        }


        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            if((hopeRadioButton4.Checked && dungeonTextBox1.Text == "") || dungeonTextBox2.Text=="" || my.получатели_количество==0)
            {
                MessageBox.Show("Заполните пожалуйста все поля");
                return;
            }

            
            if (my.media != 0)
            {
                //если выбрана мультимедиа, то отправляем файл на сервер
                byte[] bytes = System.IO.File.ReadAllBytes(openFileDialog2.FileName);

                server.send("file|" + openFileDialog2.FileName.Split("\\").Last() + "|" + bytes.Length);
                server.send_bytes(bytes);
            }

            var text = "";
            if (hopeRadioButton7.Checked)
                text = dungeonTextBox1.Text.Replace("\n", "{endline}");
            
            var accs = "";
            
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                //если акааунт для рассылки выбран
                if (((Grid_Select)flowLayoutPanel1.Controls[i]).hopeRadioButton1.Checked == true)
                {
                    accs += ((Grid_Select)flowLayoutPanel1.Controls[i]).account.phone;
                    if (i != flowLayoutPanel1.Controls.Count - 1)
                        accs += "/";
                }
                
            }
            

            server.send("new_mail|" + my.type_message + "|" + my.media + "|" + text + "|" + my.получатели_количество + "|" + my.получатели + "|" + accs);
            for(int i = 0; i < my.accounts.Count; i++)
            {
                if (accs.Contains(my.accounts[i].phone))
                {
                    my.accounts[i].status = "busy";
                }
            }
        }
       

        private void _type(object sender, EventArgs e)
        {
            my.type_message = hopeRadioButton1.Checked;
        }

        private void media(object sender, EventArgs e)
        {
            
            if (hopeRadioButton3.Checked)
            {
                //если выбрана картинка
                my.media = 1;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                load_media(new media_img());
                panel3.Size = new Size(420, 150);
                if (my.is_text)
                    panel8.Location = new Point(panel8.Location.X, 480);
                else
                    panel8.Location = new Point(panel8.Location.X, 380);
                if (my.получатели_файл_имя != "" && my.получатели_файл_имя != null)
                {
                    media_img.th.dungeonLabel3.Text = "Файл выбран";
                    Send.th.pictureBox1.ImageLocation = my.получатели_файл_имя;
                }
                    
            }
            else if (hopeRadioButton5.Checked)
            {
                //если выбрано audio
                my.media = 2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                load_media(new media_audio());
                panel3.Size = new Size(420, 130); 
            }
            else if (hopeRadioButton8.Checked)
            {
                //если выбран video
                my.media = 3;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.ImageLocation = "";
                pictureBox1.Image = Properties.Resources.img_522136;
                load_media(new media_video());
                panel3.Visible = true;
                panel3.Size = new Size(420, 130);
            }
            else
            {
                //Если не выбрана мультимедиа

                panel3.Size = new Size(420, 0);
                my.media = 0;
                panel3.Controls.Clear();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            panel2.Location = new Point(panel2.Location.X, panel3.Location.Y + panel3.Height + 10);

            panel8.Location = new Point(panel8.Location.X, panel2.Location.Y + panel2.Height + 10);

            //макет телефона
            tPanel1.Width = label1.Width + 15;
            tPanel1.Height = label1.Height + 15;
            int textlocy = panel4.Height - 150 - tPanel1.Height;
            tPanel1.Location = new Point(tPanel1.Location.X, textlocy);
            if (hopeRadioButton3.Checked || hopeRadioButton8.Checked)
            {
                pictureBox1.Location = new Point(tPanel1.Location.X, tPanel1.Location.Y - pictureBox1.Height);
                tPanel1.Width = pictureBox1.Width;
            }
            else if (hopeRadioButton5.Checked)
            {
                pictureBox2.Location = new Point(tPanel1.Location.X, tPanel1.Location.Y - pictureBox2.Height);
                tPanel1.Width = pictureBox2.Width;
            }
            if (dungeonTextBox1.Text == "")
                tPanel1.Visible = false;
            else
                tPanel1.Visible = true;
        }

        private void is_text(object sender, EventArgs e)
        {

            my.is_text = hopeRadioButton7.Checked;
            if (my.is_text)
            {
                tPanel1.Visible = true;
                tPanel3.Visible = true;
            }
            else
            {
                tPanel1.Visible = false;
                tPanel3.Visible = false;
            }

            panel8.Location = new Point(panel8.Location.X, panel2.Location.Y+panel2.Height+10);
            
        }


       
        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {
            my.получатели_текст = dungeonTextBox1.Text;
            label1.Text = dungeonTextBox1.Text;
            tPanel1.Width = label1.Width+15;
            tPanel1.Height = label1.Height+15;

            int textlocy = panel4.Height-150 - tPanel1.Height;
            tPanel1.Location = new Point(tPanel1.Location.X, textlocy);
            if (hopeRadioButton3.Checked || hopeRadioButton8.Checked)
            {
                pictureBox1.Location = new Point(tPanel1.Location.X, tPanel1.Location.Y - pictureBox1.Height);
                tPanel1.Width = pictureBox1.Width;
            }
            else if (hopeRadioButton5.Checked)
            {
                pictureBox2.Location = new Point(tPanel1.Location.X, tPanel1.Location.Y - pictureBox2.Height);
                tPanel1.Width = pictureBox2.Width;
            }
            if(dungeonTextBox1.Text=="")
                tPanel1.Visible=false;
            else
                tPanel1.Visible = true;
        }

     

        private void dungeonLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

       

        private void dungeonLabel2_Paint(object sender, PaintEventArgs e)
        {
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox4, "Какая то подсказка");
        }

        private void hopeRadioButton5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Send_Load(object sender, EventArgs e)
        {
            SetRoundedShape(panel1, 8);
        }
        internal static void REFRESH()
        {
            Send.th.Invoke(new Action(() =>
            {
                int a = 0;
                for (int i = 0; i < Send.th.flowLayoutPanel1.Controls.Count; i++)
                {
                    //если акааунт для рассылки выбран
                    if (((Grid_Select)Send.th.flowLayoutPanel1.Controls[i]).hopeRadioButton1.Checked == true)
                    {
                        a += 1;
                    }
                }
                Send.th.label7.Text = "Выбрано " + a + " аккаунтов.";
            }));
        }
    }
}
