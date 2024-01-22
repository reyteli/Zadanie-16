using System;
using System.Text.Json;
using System.IO;


namespace zadanie_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../../Tovari.json"))
            {
                 jsonString = sr.ReadToEnd();
            }
            Tovar[] tovari = JsonSerializer.Deserialize<Tovar[]>(jsonString);
            Tovar maxTovar = tovari[0];
            foreach(Tovar e in tovari)
            {
                if(e.Cena>maxTovar.Cena)
                {
                    maxTovar = e;
                }
            }
            Console.WriteLine($"{maxTovar.Kod} {maxTovar.Nazvanie} {maxTovar.Cena}");
            Console.ReadKey();
        }
    }
}
