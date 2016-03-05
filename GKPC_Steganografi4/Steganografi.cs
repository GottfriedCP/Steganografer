/*
    - Kelas utama yang digunakan utk Steganografi, baik Hide maupun Ekstrak
*/

using System;
using System.Drawing;

namespace GKPC_Steganografi4
{
    class Steganografi
    {
        public enum Status
        {
            Menyembunyikan,
            Mengisi_Nol
        };

        public static Bitmap Hide(string teks, Bitmap bmp)
        {
            Status status = Status.Menyembunyikan;

            int charIdx = 0;        // Menampung index karakter yg sedang disembunyikan
            int charVal = 0;        // Menampung nilai int dari karakter
            long pxlElementIdx = 0; // Menampung index elemen warna (R/G/B) yang sedang diproses
            int zeros = 0;          // Menampung jumlah nol yang di-append saat menyelesaikan proses
            int R = 0, G = 0, B = 0;    // Menampung elemen pixel
            
            // Iterasi baris
            for (int i = 0; i < bmp.Height; i++)
            {
                // Iterasi kolom tiap baris
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i); // Menampung pixel yang sedang diproses
                    // Menghapus LSB tiap elemen pixel
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    // Iterasi RGB tiap pixel
                    for (int n = 0; n < 3; n++)
                    {
                        if (pxlElementIdx % 8 == 0) // Cek apakah 8-bit baru sudah diproses
                        {
                            // cek apakah 8 zero sudah ditambahkan (--> proses selesai)
                            if (status == Status.Mengisi_Nol && zeros == 8)
                            {
                                // Menerapkan pixel terakhir gambar
                                if ((pxlElementIdx - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp; // Proses selesai (utk IF ini)
                            }

                            // Cek apakah semua karakter sudah tersembunyi
                            if (charIdx >= teks.Length)
                            {
                                // Mulai mengisi dengan nol utk menandai akhir teks
                                status = Status.Mengisi_Nol;
                            }
                            else
                            {
                                // Memproses karakter selanjutnya dari teks yg akan disembunyikan
                                charVal = teks[charIdx++];
                            }
                        }

                        // Cek giliran elemen pxl mana yg harus menyembunyikan bit dalam LSB-nya
                        switch (pxlElementIdx % 3)
                        {
                            case 0:
                                {
                                    if (status == Status.Menyembunyikan)
                                    {
                                        // bit paling kanan pada karakter adalah (charVal % 2)
                                        // Nilai ini tinggal di tambahkan karena LSB sudah nol
                                        R += charVal % 2;
                                        // Bit paling kanan karakter kemudian dihilangkan
                                        charVal /= 2;
                                    }
                                } break;
                            case 1:
                                {
                                    if (status == Status.Menyembunyikan)
                                    {
                                        G += charVal % 2;
                                        charVal /= 2;
                                    }
                                } break;
                            case 2:
                                {
                                    if (status == Status.Menyembunyikan)
                                    {
                                        B += charVal % 2;
                                        charVal /= 2;
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                } break;
                        }

                        pxlElementIdx++;
                        
                        if (status == Status.Mengisi_Nol)
                        {
                            zeros++;    // Increment sampai zeros == 8
                        } 
                    }
                }
            } 
            
            return bmp;
        }

        public static String Ekstrak(Bitmap bmp)
        {
            int clrUnitIdx = 0;
            int charVal = 0;
            string teksHasil = "";

            for (int i = 0; i < bmp.Height; i++) // Iterasi baris
            {
                for (int j = 0; j < bmp.Width; j++) // Iterasi tiap kolom pada baris
                {
                    Color px = bmp.GetPixel(j, i);
                    for (int n = 0; n < 3; n++) // Iterasi elemen RGB tiap pixel
                    {
                        switch (clrUnitIdx % 3)
                        {
                            case 0:
                                {
                                    // Setelah bersusah-susah, diajari masternya di forum coding
                                    // Dikasih rumus ini
                                    // Maaf ya
                                    charVal = charVal * 2 + px.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charVal = charVal * 2 + px.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charVal = charVal * 2 + px.B % 2;
                                }
                                break;
                        }

                        clrUnitIdx++;

                        // Jika sudah 8 bit, jadikan karakter lalu append ke string output
                        if (clrUnitIdx % 8 == 0)
                        {
                            charVal = reverseBits(charVal);
                            if (charVal == 0) // Alias bit 0 sebanyak 8 (00000000)
                            {
                                return teksHasil;
                            }

                            char kar = (char)charVal; // Konversi dari int ke char..
                            teksHasil += kar.ToString();
                        }
                    }
                }
            }

            return teksHasil;
        }

        // Method pembantu yang digunakan untuk membaca bit dari belakang (reverse)
        public static int reverseBits(int n)
        {
            int hasil = 0;
            for (int i = 0; i < 8; i++)
            {
                hasil = hasil * 2 + n % 2;
                n /= 2;
            }
            return hasil;
        }
    }
}
