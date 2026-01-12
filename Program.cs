using System.ComponentModel.Design;

int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Input Nama: ");
nama = Console.ReadLine();

Console.Write("Input nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("selamat anda lulus");

else
    Console.WriteLine("maaf anda belum lulus");