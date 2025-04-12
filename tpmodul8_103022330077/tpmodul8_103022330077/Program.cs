using System;

class Program
{
    static void Main(string[] args)
    {

        CovidConfig config = new CovidConfig();


        Console.WriteLine($"berapa suhu saat ini? {config.config1}");


        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai <{config.config1}>: ");
        double suhuBadan = Convert.ToDouble(Console.ReadLine());


        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDeman = Convert.ToInt32(Console.ReadLine());


        double suhuMin = config.config1 == "celcius" ? 36.5 : 97.7;
        double suhuMax = config.config1 == "celcius" ? 37.5 : 99.5;


        if (suhuBadan >= suhuMin && suhuBadan <= suhuMax && hariDeman < config.config2)
        {
            Console.WriteLine(config.config4);
        }
        else
        {
            Console.WriteLine(config.config3);
        }

        Console.Write("Apakah Anda ingin mengubah satuan suhu? (ya/tidak): ");
        string ubahSatuan = Console.ReadLine().ToLower();

        if (ubahSatuan == "ya")
        {
            config.UbahSatuan();
            Console.WriteLine("Satuan suhu telah diperbarui.");
            Console.WriteLine($"Satuan suhu saat ini: {config.config1}");
        }
    }
}
