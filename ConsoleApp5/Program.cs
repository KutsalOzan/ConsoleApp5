using System;
using System.Drawing;

namespace ConsoleApp5
{
    public class Motor
    {



        public Motor()
        {
            Renk = Color.Bisque;
            VitesSayisi = 5;
            YakitCinsi = "benzin";
        }


        public Color Renk { get; set; }
        public byte VitesSayisi { get; set; }
        public string YakitCinsi { get; set; }

        public void Git() => Console.WriteLine("Gidiyorum");
        public void Dur() => Console.WriteLine("Durdum");
        public void VitesDegis() => Console.WriteLine("Vites Değiştir");

        public void FarYak() => Console.WriteLine("Farları Yak");
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();
            Console.WriteLine("Değer atanmadığı için varsalıyan");
            Console.WriteLine("Değerler Görüntülendi");

            Console.WriteLine("Renk Özelliği: " + motor.Renk);
            Console.WriteLine("Vites Sayısı Özelliği: " + motor.VitesSayisi);
            Console.WriteLine("Yakıt Cinsi Özelliği: " + motor.YakitCinsi);
            Console.WriteLine("------------------------------------------------");
            Console.Write("Özelliklere değer atandıktan sonra: ");
            motor.Renk = Color.White;
            Console.WriteLine("Renk Özelliği: " + motor.Renk);
            motor.VitesSayisi = 10;
            Console.WriteLine("Vites Sayısı Özelliği " + motor.VitesSayisi);
            motor.YakitCinsi = "Elektrikli Motor";
            Console.WriteLine("Yakıt Cinsi Özelliği " +  motor.YakitCinsi);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Metotlar");
            motor.Git();
            motor.Dur();
            motor.VitesDegis();
            motor.FarYak();
            Console.ReadLine();
        }
    }
}
