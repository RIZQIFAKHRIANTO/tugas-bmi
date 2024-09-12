using System;

class Program
{
    static void Main()
    {
        // Meminta input berat badan dan tinggi badan dari pengguna
        Console.Write("Masukkan berat badan (kg): ");
        double beratBadan = double.Parse(Console.ReadLine());

        Console.Write("Masukkan tinggi badan (cm): ");
        double tinggiBadan = double.Parse(Console.ReadLine());

        // Menghitung BMI
        double bmi = beratBadan / (tinggiBadan * tinggiBadan);

        // Menampilkan hasil BMI
        Console.WriteLine($"BMI Anda adalah: {bmi:F2}");

        // Menentukan kategori BMI
        if (bmi < 18.5)
            Console.WriteLine("Kategori: Berat badan kurang");
        else if (bmi < 25)
            Console.WriteLine("Kategori: Berat badan normal");
        else if (bmi < 30)
            Console.WriteLine("Kategori: Kelebihan berat badan");
        else
            Console.WriteLine("Kategori: Obesitas");
    }
}
