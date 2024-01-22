using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Zadanie_16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Tovar[] tovari = new Tovar[n];

            for (int i = 0; i < n; i++)
            {



                Console.WriteLine("введите код");
                int kod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите название");
                string nazvanie = Console.ReadLine();
                Console.WriteLine("ведите цену");
                float cena = (float)Convert.ToDouble(Console.ReadLine());

               tovari[i] = new Tovar() { Kod = kod, Nazvanie = nazvanie, Cena = cena };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(tovari, options);

            using (StreamWriter sw = new StreamWriter("../../../../Tovari.json"))
            {
                sw.WriteLine(jsonString);
            }
        }


    }
}
