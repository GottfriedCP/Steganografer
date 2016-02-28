/*
    - Program utk menyembunyikan pesan teks ke dalam gambar
    - Setiap kar teks pesan dijadikan biner dan disisipkan sbg bit terakhir
        tiap R, G, B pixel
*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GKPC_Steganografi4
{
    public partial class Form1 : Form
    {
        Bitmap gambarBmp;
        string namaFile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtInOut.Text = "";
        }


        // Button utk enkripsi teks ke dalam gambar
        private void btnEnc_Click(object sender, EventArgs e)
        {
            if (namaFile == "" && txtInOut.Text == "")
            {
                MessageBox.Show("Gambar belum dimuat", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            else if(txtInOut.Text == "")
            {
                MessageBox.Show("Tidak ada pesan untuk ditulis", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            else
            {
                // Algoritma dilakukan oleh kelas tersendiri (Steganografi)
                gambarBmp = Steganografi.Encrypt(txtInOut.Text, gambarBmp);

                // Menyimpan gambar dengan pesan teks tersembunyi sbg gambar baru 
                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Title = "Simpan Sebagai";
                saveFD.Filter = "Bmp File|*.bmp";
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MemoryStream memory = new MemoryStream())
                        {
                            using (FileStream fs = new FileStream(saveFD.FileName, FileMode.Create, FileAccess.ReadWrite))
                            {
                                gambarBmp.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                                byte[] bytes = memory.ToArray();
                                fs.Write(bytes, 0, bytes.Length);
                            }
                        }
                        //gambarBmp.Save(saveFD.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Gambar berhasil disimpan", "STATUS", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                        //gambarBmp.Dispose();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Button utk membuka gambar utk diproses (Enkripsi/Dekripsi)
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD1 = new OpenFileDialog();
            openFD1.Title = "Pilih File";
            openFD1.Filter = "Image Files (*.bmp; *.jpeg; *.png )|*.bmp; *.jpg; *.png; ";

            if (openFD1.ShowDialog() == DialogResult.OK)
            {
                txtInOut.Enabled = true;
                namaFile = openFD1.FileName;
                lblNama.Text = namaFile;

                // Dispose dan muat image ke picBox dari dialog
                if (picBox1.Image != null) { picBox1.Image.Dispose(); }
                picBox1.Image = Image.FromFile(namaFile);

                // Dispose dan buat Bmp baru dari dialog
                if (gambarBmp != null) { gambarBmp.Dispose(); }
                gambarBmp = new Bitmap(namaFile);

                // Kode-kode untuk menampilkan detail gambar
                lblHei.Text = gambarBmp.Height.ToString() + " px";
                lblWid.Text = gambarBmp.Width.ToString() + " px";
                lblHres.Text = gambarBmp.HorizontalResolution.ToString() + " px/inch";
                lblVres.Text = gambarBmp.VerticalResolution.ToString() + " px/inch";
                lblInOut.Text = "PESAN UNTUK DISIMPAN:";
            }
        }

        // Ekspor pesan teks ke dalam file .txt jika perlu
        private void btnEkprt_Click(object sender, EventArgs e)
        {
            if (txtInOut.Text == "")
            {
                MessageBox.Show("Tidak ada teks untuk diekspor", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog saveFD2 = new SaveFileDialog();
                saveFD2.Title = "Ekspor";
                saveFD2.Filter = "Text File|*.txt";
                if (saveFD2.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFD2.FileName, txtInOut.Text);
                }
            }
        }

        // Button utk dekripsi gambar (menampilkan pesan teks rahasia)
        private void btnDec_Click(object sender, EventArgs e)
        {
            if (namaFile == "")
            {
                MessageBox.Show("Gambar belum dimuat", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            else
            {
                if (Steganografi.Decrypt(gambarBmp).Length > 20000)
                {
                    MessageBox.Show("Isi pesan terlalu besar", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                else
                {
                    // Algoritma dilakukan oleh kelas tersendiri (Steganografi)
                    txtInOut.Text = Steganografi.Decrypt(gambarBmp);
                    lblInOut.Text = "PESAN DALAM GAMBAR:";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInOut.Enabled = false;
            lblNama.Text = "HINT: Muat Gambar, ketik pesan teks, lalu pilih Enkrip ke Gambar";
        }
    }
}
