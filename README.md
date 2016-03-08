# Steganografi
Steganografer - Program untuk menyembunyikan teks dalam gambar digital (format Bmp/Jpeg/Png) lalu menyimpannya sebagai file gambar baru dalam format Bmp

## Overview
Program dibuat dalam bahasa C# menggunakan Visual Studio Express 2015, memanfaatkan beberapa kelas bawaan yang tersedia

File-file utama:
* Form1.cs         (form dan elemen-elemen GUI) 
* Steganografi.cs  (kelas berisi 2 static method)

Singkatnya, satu karakter dari teks yang hendak disembunyikan diubah menjadi 8 bit (1 dan 0), menggantikan LSB (Least Significant Bit) RGB dari pixel (R1, G1, B1, hingga B3) lalu dilanjutkan karakter-karakter selanjutnya

## Lisensi
Seluruh source code terlisensi di bawah [CPOL] (http://www.codeproject.com/info/cpol10.aspx)

