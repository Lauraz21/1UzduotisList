using System.Collections.Generic;

namespace _1UzduotisList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();

            city.Add("Vilnius");
            city.Add("Kaunas");
            city.Add("Klaipeda");

            LengthOfCity(city);
        }
        public static void LengthOfCity(List<string> city)
        {
            foreach (string s in city)
            {
                Console.WriteLine(s.Length);
            }
        }
    }
}
