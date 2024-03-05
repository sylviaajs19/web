// Import namespace
using coba2;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mengatur sumber gambar dari file GIF
pictureBox1.ImageLocation = "path/to/your/animated.gif";

// Menghidupkan animasi
pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

// Menunggu selama 5 detik
await Task.Delay(5000);

// Pindah ke Form 2

form2.Show();
this.Hide();  // Menghilangkan Form 1 jika diperlukan
