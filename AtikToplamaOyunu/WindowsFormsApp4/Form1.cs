


                                                                //AD: BERKAY EŞER
                                                                //NO: B191210371
                                                                //DERS ADI: NESNEYE DAYALI PROGRAMLAMA
                                                                //GRUP: 1C











using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kalan Süre ve Puan tanımlandı ve rastegele bir atık vermesi için kontrol ile random komutu.
        int sure = 60;
        int puan = 0;
        int rastgeleAtik;
        public bool kontrol;


        Random rastgele = new Random();

        //Atıklar ve Atık Kutuları oluşturuldu.
        Atik kolaKutusu = new Atik();
        Atik salcaKutusu = new Atik();
        Atik camSise = new Atik();
        Atik bardak = new Atik();
        Atik gazete = new Atik();
        Atik dergi = new Atik();
        Atik domates = new Atik();
        Atik salatalik = new Atik();

        AtikKutusu organikAtikKutusu = new AtikKutusu();
        AtikKutusu metalKutusu = new AtikKutusu();
        AtikKutusu camKutusu = new AtikKutusu();
        AtikKutusu kagitKutusu = new AtikKutusu();

        

        private void Form1_Load(object sender, EventArgs e) //uygulama ekranı ilk açıldığında olacak olaylar ve değer atamaları.
        {


            //Metal atıklara değer atama
            kolaKutusu.Hacim = 350;
            kolaKutusu.Image = Image.FromFile(Application.StartupPath + "\\resimler\\"  +1 + ".jpg");
            kolaKutusu.Ad = "Kola Kutusu(350)";

            salcaKutusu.Hacim = 550;
            salcaKutusu.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + 2 + ".jpg");
            salcaKutusu.Ad = "Salça Kutusu(550)";

            //Cam atıklara değer atama.
            camSise.Hacim = 600;
            camSise.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + 3 + ".jpg");
            camSise.Ad = "Cam Şişe(600)";

            bardak.Hacim = 250;
            bardak.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + 4 + ".jpg");
            bardak.Ad = "Bardak(250)";

            //kağıt atıklara değer atama.
            gazete.Hacim = 250;
            gazete.Image= Image.FromFile(Application.StartupPath + "\\resimler\\" + 5 + ".jpg");
            gazete.Ad = "Gazete(250)";

            dergi.Hacim = 200;
            dergi.Image=Image.FromFile(Application.StartupPath + "\\resimler\\" + 6 + ".jpg");
            dergi.Ad = "Dergi(200)";

            //organik atıklara değer atama
            domates.Hacim = 150;
            domates.Image= Image.FromFile(Application.StartupPath + "\\resimler\\" + 7 + ".jpg");
            domates.Ad = "Domates(150)";

            salatalik.Hacim = 120;
            salatalik.Image= Image.FromFile(Application.StartupPath + "\\resimler\\" + 8 + ".jpg");
            salatalik.Ad = "Salatalık(120)";

            //atıkları numaralandırma
            kolaKutusu.AtikNo = 1;
            salcaKutusu.AtikNo = 2;
            camSise.AtikNo = 3;
            bardak.AtikNo = 4;
            gazete.AtikNo = 5;
            dergi.AtikNo = 6;
            domates.AtikNo = 7;
            salatalik.AtikNo = 8;


            //atık kutularının özellikleri
            organikAtikKutusu.Kapasite = 700;
            metalKutusu.Kapasite = 2300;
            camKutusu.Kapasite = 2200;
            kagitKutusu.Kapasite = 1200;

            organikAtikKutusu.DoluHacim = 0;
            metalKutusu.DoluHacim = 0;
            camKutusu.DoluHacim = 0;
            kagitKutusu.DoluHacim = 0;

            organikAtikKutusu.BosaltmaPuani = 0;
            kagitKutusu.BosaltmaPuani = 1000;
            camKutusu.BosaltmaPuani = 600;
            metalKutusu.BosaltmaPuani = 800;

            
            //İlerleme çubukları,atık kutularının hacmine göre ilerleyecek.
            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

            //Oyun ekranı ilk açıldığında yeni oyun butonu dışında bütün butonlar ve timer etkisiz halde.
            textBox1.Enabled = false;
            
            listBox1.Enabled = false;
            listBox2.Enabled = false;
            listBox3.Enabled = false;
            listBox4.Enabled = false;

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Sürenin 60 tan 0 a doğru azalması.
            textBox7.Text = Convert.ToString(sure);
            sure--;

            

            if (sure == 0)
            {
                //Süre sıfırlandığında olacak olaylar ve değer atamaları.
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                organikAtikKutusu.DoluHacim = 0;
                metalKutusu.DoluHacim = 0;
                camKutusu.DoluHacim = 0;
                kagitKutusu.DoluHacim = 0;

                progressBar1.Value = organikAtikKutusu.DoluHacim;
                progressBar2.Value = kagitKutusu.DoluHacim;
                progressBar3.Value = camKutusu.DoluHacim;
                progressBar4.Value = metalKutusu.DoluHacim;

                timer1.Enabled = false;

                listBox1.Enabled = false;
                listBox2.Enabled = false;
                listBox3.Enabled = false;
                listBox4.Enabled = false;

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) //yeni oyun butonuna tıklanması.
        {
            sure = 60;
            puan = 0;
            textBox9.Text = Convert.ToString(puan);


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            rastgeleAtik = rastgele.Next(1, 9); 
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + rastgeleAtik + ".jpg");

            timer1.Interval = 1000;
            timer1.Enabled = true;
            
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            listBox3.Enabled = true;
            listBox4.Enabled = true;

            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            

            organikAtikKutusu.DoluHacim = 0;
            metalKutusu.DoluHacim = 0;
            camKutusu.DoluHacim = 0;
            kagitKutusu.DoluHacim = 0;

            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

            if (rastgeleAtik==kolaKutusu.AtikNo)
            {
                button7.Enabled = true;
            }
            if (rastgeleAtik == salcaKutusu.AtikNo)
            {
                button7.Enabled = true;
            }
            if (rastgeleAtik==camSise.AtikNo)
            {
                button8.Enabled = true;
            }
            if (rastgeleAtik==bardak.AtikNo)
            {
                button8.Enabled = true;
            }
            if (rastgeleAtik==gazete.AtikNo)
            {
                button9.Enabled = true;
            }
            if (rastgeleAtik==dergi.AtikNo)
            {
                button9.Enabled = true;
            }
            if (rastgeleAtik==domates.AtikNo)
            {
                button10.Enabled = true;
            }
            if (rastgeleAtik==salatalik.AtikNo)
            {
                button10.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //organik atık kutusu boşaltma butonuna tıklanması.
        {
            organikAtikKutusu.DolulukOrani = Convert.ToDouble(organikAtikKutusu.DoluHacim) / Convert.ToDouble(organikAtikKutusu.Kapasite);

            kontrol = organikAtikKutusu.Bosalt();

            if (kontrol==true)
            {
                progressBar1.Value = organikAtikKutusu.DoluHacim;
                listBox1.Items.Clear();
                puan += organikAtikKutusu.BosaltmaPuani;
                textBox9.Text = Convert.ToString(puan);
                sure += 3;
                if (rastgeleAtik == 7 || rastgeleAtik == 8)
                {
                    button10.Enabled = true;
                }
                else
                {
                    button10.Enabled = false;
                }
            }
            else
            {
                kontrol = false;
            }
           
        }

        private void button4_Click(object sender, EventArgs e) //kağıt kutusu boşaltma butonuna tıklanması.
        {
            kagitKutusu.DolulukOrani = Convert.ToDouble(kagitKutusu.DoluHacim) / Convert.ToDouble(kagitKutusu.Kapasite);

            kontrol = kagitKutusu.Bosalt();

            if (kontrol==true)
            {
                progressBar2.Value = kagitKutusu.DoluHacim;
                listBox2.Items.Clear();
                puan += kagitKutusu.BosaltmaPuani;
                textBox9.Text =Convert.ToString(puan);
                sure += 3;
                if (rastgeleAtik==5 || rastgeleAtik==6)
                {
                    button9.Enabled = true;
                }
                else
                {
                    button9.Enabled = false;
                }
            }
            else
            {
                kontrol = false;
            }
            
        }

        private void button5_Click(object sender, EventArgs e) //cam kutusu boşaltma butonuna tıklanması.
        {
            camKutusu.DolulukOrani =Convert.ToDouble(camKutusu.DoluHacim) / Convert.ToDouble(camKutusu.Kapasite);

            kontrol = camKutusu.Bosalt();

            if (kontrol == true)
            {
                progressBar3.Value = camKutusu.DoluHacim;
                listBox3.Items.Clear();
                puan += camKutusu.BosaltmaPuani;
                textBox9.Text = Convert.ToString(puan);
                sure += 3;

                if (rastgeleAtik==3 || rastgeleAtik==4 )
                {
                    button8.Enabled = true;
                }
                else
                {
                    button8.Enabled = false;
                }
            }
            else
            {
                kontrol = false;
            }

        }

        private void button6_Click(object sender, EventArgs e) //metal kutusu boşaltma butonuna tıklanması.
        {
            metalKutusu.DolulukOrani = (Convert.ToDouble(metalKutusu.DoluHacim)) / (Convert.ToDouble(metalKutusu.Kapasite));

            kontrol = metalKutusu.Bosalt();

            if (kontrol == true)
            {
                progressBar4.Value = metalKutusu.DoluHacim;
                listBox4.Items.Clear();
                puan += metalKutusu.BosaltmaPuani;
                textBox9.Text = Convert.ToString(puan);
                sure += 3;

                if (rastgeleAtik==1 || rastgeleAtik==2)
                {
                    button7.Enabled = true;
                }
                else
                {
                    button7.Enabled = false;
                }
            }
            else
            {
                kontrol = false;
            }
        }

        private void button10_Click(object sender, EventArgs e) //organik atık kutusuna atık ekleme butonuna tıklanması.
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            


            if (rastgeleAtik==domates.AtikNo)
            {
                puan = puan + domates.Hacim;
                organikAtikKutusu.DoluHacim += domates.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox1.Items.Add(domates.Ad);
                
            }
            else if (rastgeleAtik==salatalik.AtikNo)
            {
                puan = puan + salatalik.Hacim;
                organikAtikKutusu.DoluHacim += salatalik.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox1.Items.Add(salatalik.Ad);
                
            }


            

            rastgeleAtik = rastgele.Next(1, 9);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + rastgeleAtik + ".jpg");

            if ((rastgeleAtik == kolaKutusu.AtikNo) && ((metalKutusu.DoluHacim + kolaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == salcaKutusu.AtikNo) && ((metalKutusu.DoluHacim + salcaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == camSise.AtikNo) && ((camKutusu.DoluHacim + camSise.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == bardak.AtikNo) && ((camKutusu.DoluHacim + bardak.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == gazete.AtikNo) && ((kagitKutusu.DoluHacim + gazete.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == dergi.AtikNo) && ((kagitKutusu.DoluHacim + dergi.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == domates.AtikNo) && ((organikAtikKutusu.DoluHacim + domates.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            if ((rastgeleAtik == salatalik.AtikNo) && ((organikAtikKutusu.DoluHacim + salatalik.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

           
        }

        private void button9_Click(object sender, EventArgs e) //kağıt kutusuna atık ekleme butonuna tıklanması.
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            


            if (rastgeleAtik==gazete.AtikNo)
            {
                puan = puan + gazete.Hacim;
                kagitKutusu.DoluHacim += gazete.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox2.Items.Add(gazete.Ad);
                
            }
            else if (rastgeleAtik==dergi.AtikNo)
            {
                puan = puan + dergi.Hacim;
                kagitKutusu.DoluHacim += dergi.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox2.Items.Add(dergi.Ad);
                
            }


            rastgeleAtik = rastgele.Next(1, 9);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + rastgeleAtik + ".jpg");

            if ((rastgeleAtik == kolaKutusu.AtikNo) && ((metalKutusu.DoluHacim + kolaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == salcaKutusu.AtikNo) && ((metalKutusu.DoluHacim + salcaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == camSise.AtikNo) && ((camKutusu.DoluHacim + camSise.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == bardak.AtikNo) && ((camKutusu.DoluHacim + bardak.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == gazete.AtikNo) && ((kagitKutusu.DoluHacim + gazete.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == dergi.AtikNo) && ((kagitKutusu.DoluHacim + dergi.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == domates.AtikNo) && ((organikAtikKutusu.DoluHacim + domates.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            if ((rastgeleAtik == salatalik.AtikNo) && ((organikAtikKutusu.DoluHacim + salatalik.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

            

        }

        private void button8_Click(object sender, EventArgs e) //cam kutusuna atık ekleme butonuna tıklanması.
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

           

            if (rastgeleAtik==bardak.AtikNo)
            {
                puan = puan + bardak.Hacim;
                camKutusu.DoluHacim += bardak.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox3.Items.Add(bardak.Ad);
                
            }
            else if (rastgeleAtik==camSise.AtikNo)
            {
                puan = puan + camSise.Hacim;
                camKutusu.DoluHacim += camSise.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox3.Items.Add(camSise.Ad);
                
            }


            rastgeleAtik = rastgele.Next(1, 9);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + rastgeleAtik + ".jpg");

            if ((rastgeleAtik == kolaKutusu.AtikNo) && ((metalKutusu.DoluHacim + kolaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == salcaKutusu.AtikNo) && ((metalKutusu.DoluHacim + salcaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == camSise.AtikNo) && ((camKutusu.DoluHacim + camSise.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == bardak.AtikNo) && ((camKutusu.DoluHacim + bardak.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == gazete.AtikNo) && ((kagitKutusu.DoluHacim + gazete.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == dergi.AtikNo) && ((kagitKutusu.DoluHacim + dergi.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == domates.AtikNo) && ((organikAtikKutusu.DoluHacim + domates.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            if ((rastgeleAtik == salatalik.AtikNo) && ((organikAtikKutusu.DoluHacim + salatalik.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

           
        }

        private void button7_Click(object sender, EventArgs e) //metal kutusuna atık ekleme butonuna tıklanması.
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;


            if (rastgeleAtik==kolaKutusu.AtikNo)
            {
                puan = puan + kolaKutusu.Hacim;
                metalKutusu.DoluHacim += kolaKutusu.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox4.Items.Add(kolaKutusu.Ad);
                
            }
            else if (rastgeleAtik==salcaKutusu.AtikNo)
            {
                puan = puan + salcaKutusu.Hacim;
                metalKutusu.DoluHacim += salcaKutusu.Hacim;
                textBox9.Text = Convert.ToString(puan);
                listBox4.Items.Add(salcaKutusu.Ad);
                
            }


            rastgeleAtik = rastgele.Next(1, 9);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + rastgeleAtik + ".jpg");

            if ((rastgeleAtik == kolaKutusu.AtikNo) && ((metalKutusu.DoluHacim + kolaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == salcaKutusu.AtikNo) && ((metalKutusu.DoluHacim + salcaKutusu.Hacim) <= metalKutusu.Kapasite))
            {
                button7.Enabled = true;
            }
            if ((rastgeleAtik == camSise.AtikNo) && ((camKutusu.DoluHacim + camSise.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == bardak.AtikNo) && ((camKutusu.DoluHacim + bardak.Hacim) <= camKutusu.Kapasite))
            {
                button8.Enabled = true;
            }
            if ((rastgeleAtik == gazete.AtikNo) && ((kagitKutusu.DoluHacim + gazete.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == dergi.AtikNo) && ((kagitKutusu.DoluHacim + dergi.Hacim) <= kagitKutusu.Kapasite))
            {
                button9.Enabled = true;
            }
            if ((rastgeleAtik == domates.AtikNo) && ((organikAtikKutusu.DoluHacim + domates.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }
            if ((rastgeleAtik == salatalik.AtikNo) && ((organikAtikKutusu.DoluHacim + salatalik.Hacim) <= organikAtikKutusu.Kapasite))
            {
                button10.Enabled = true;
            }

            progressBar1.Value = organikAtikKutusu.DoluHacim;
            progressBar2.Value = kagitKutusu.DoluHacim;
            progressBar3.Value = camKutusu.DoluHacim;
            progressBar4.Value = metalKutusu.DoluHacim;

           
        }

        private void button2_Click(object sender, EventArgs e)//çıkış butonuna tıklanması
        {
            //çıkış butonu
            this.Close();
            Application.Exit();
        }
    }
}
