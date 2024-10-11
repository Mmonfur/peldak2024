using System;
using System.Drawing;
using System.Dynamic;
using System.Xml.Linq;

namespace CollectionDemo
{
    internal class Program  //comments
    {
        static void Main(string[] args)
        {
            //This calls NumberSources.GetNumbers(5), which is a generator method that lazily yields integers from 0 to 4.
            var enumerable = NumberSources.GetNumbers(5);
            //An IEnumerator object(enumerator) is created by calling GetEnumerator() on the IEnumerable<int> that is returned.
            var enumerator = enumerable.GetEnumerator();

            // This loop prints numbers 0 through 4.
            while (enumerator.MoveNext()) //következő elemre lép az enumerátor
            {
                Console.WriteLine(enumerator.Current);  //aktuális elemet lekéri
            }


            var lista = new List<int>()  // lista pédányosítása
            {
                1,2,3,4  // inicializálás, beaállítja az elemeket
            };

            var listb = enumerable.ToList();

            listb.Add(1);
            Console.WriteLine(listb.Count);

            var szam = lista[0];

            var dictionary = new Dictionary<int, string>()
            {
                {1, "asd" },
                {2, "bsd" },
            };

            dictionary.Add(3, "asd");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            var elem = dictionary[1];

            var items = NumberSources.GetNumbers(1).Take2();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            var vector = new Vector<int>(1, 2);
            Console.WriteLine(vector.X);

            var vector2 = new Vector<double>(1.1, 2.1);
            Console.WriteLine(vector2.X);
        }
    }
}