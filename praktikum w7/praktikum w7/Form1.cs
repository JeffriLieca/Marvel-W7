using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_w7
{
    public partial class Form1 : Form
    {
        DataTable tampilan = new DataTable();
        int x = 0;
        List<Button> btn = new List<Button>();
        List<Label> item = new List<Label>();
        List<Label> hrga = new List<Label>();
        List<string> Tshirt = new List<string>() { "U Crew Neck Short-Sleeve T-Shirt", "DRY-EX Crew Neck Short-Sleeve T-Shirt", "Supima Cotton Crew Neck Short-Sleeve T-Shirt" };
        List<Int32> hargaT = new List<Int32>() { 170000, 220000, 270000 };

        List<string> shirt = new List<string>() { "Premium Linen Long-Sleeve Shirt", "DRY-EX Short-Sleeve Polo Shirt", "Open Collar Short-Sleeve Shirt" };
        List<Int32> hargas = new List<Int32>() { 350000, 230000, 450000 };

        List<string> shorts = new List<string>() { "Dry Stretch Easy Shorts", "Chino Shorts", "Linen Blend Shorts" };
        List<Int32> hargaS = new List<Int32>() { 350000, 450000, 450000 };

        List<string> longpants = new List<string>() { "AIRism Soft Flare Leggings", "AIRism UV Protection Pocketed Soft Leggings", "Baker Pants" };
        List<Int32> hargaL = new List<Int32>() { 350000, 350000, 450000 };

        List<string> emas = new List<string>() { "Cincin", "Anting - anting", "Kalung" };
        List<Int32> hargaE = new List<Int32>() { 1000000, 2000000, 3000000 };

        List<string> sepatu = new List<string>() { "Sepatu Hitam", "Sepatu Biru", "Sepatu Merah" };
        List<Int32> hargaspatu= new List<Int32>() { 500000, 700000, 600000 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampilan.Columns.Add("Item");
            tampilan.Columns.Add("Qty");
            tampilan.Columns.Add("Price");
            tampilan.Columns.Add("Total");
            data.DataSource = tampilan;
        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listTshirt.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = Tshirt[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargaT[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listshirt.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = shirt[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargas[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }

        private void shortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listshorts.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = shorts[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargaS[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listlongpants.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = longpants[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargaL[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }

        private void jewelleriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listperhiasan.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = emas[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargaE[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            x = 0;
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Image = listsepatu.Images[i];
                gambar.Location = new Point(12 + x, 5);
                gambar.Size = new Size(150, 200);
                panel1.Controls.Add(gambar);
                Label nama = new Label();
                nama.Text = sepatu[i];
                nama.Location = new Point(5 + x, 220);
                nama.AutoSize = true;
                item.Add(nama);
                panel1.Controls.Add(nama);
                Label hrg = new Label();
                hrg.Text = hargaspatu[i].ToString();
                hrg.Location = new Point(5 + x, 230);
                hrg.AutoSize = true;
                hrga.Add(hrg);
                panel1.Controls.Add(hrg);
                Button beli = new Button();
                beli.Text = "Buy";
                beli.AutoSize = true;
                beli.Tag = "Buy" + Tshirt[i];
                beli.Location = new Point(5 + x, 250);
                beli.Size = new Size(20, 20);
                panel1.Controls.Add(beli);
                btn.Add(beli);
                beli.Click += buy_Click;
                x += 170;
            }
        }
        string itemku = "";
        int qty = 0;
        int price = 0;
        int totalbeli = 0;
        int cek = 0;
        int subtotal = 0;
        private void buy_Click(object sender, EventArgs e)
        {
            cek = 0;
            subtotal = 0;
            Button pencet = sender as Button;
            for (int i = 0; i < btn.Count; i++)
            {
                if (btn[i].Tag == pencet.Tag)
                {
                    
                    foreach (DataRow a in tampilan.Rows)
                    {
                        if (a[0].ToString() == item[i].Text)
                        {
                            cek = 1;
                        }
                    } 
                    if (cek == 1)
                    {
                        qty++;
                        tampilan.Rows[i][1] = qty;
                        totalbeli = totalbeli + price;
                        tampilan.Rows[i][3] = totalbeli;
                    }
                    else
                    {
                        qty = 0;
                        totalbeli = 0;
                        itemku = item[i].Text;
                        price = Convert.ToInt32(hrga[i].Text);
                        qty++;
                        totalbeli = qty * price;
                        tampilan.Rows.Add(itemku, qty, price, totalbeli);   
                    }
                    foreach (DataRow a in tampilan.Rows)
                    {
                        subtotal += Convert.ToInt32(a[3]);
                    }
                    sub.Text = subtotal.ToString();
                    total.Text = Convert.ToInt32((subtotal * 1.1)).ToString();
                }
            }
            
        }
    }
}
