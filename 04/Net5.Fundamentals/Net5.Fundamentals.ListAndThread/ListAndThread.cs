using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.ListAndThread
{
    public class ListAndThread
    {
        public void ArraySample()
        {
            Console.WriteLine("Array");
            Console.WriteLine("=====");

            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"array[{i}] : {array[i]}");
            }
            Console.WriteLine($"Size : {array.Length}");

            Console.WriteLine("");
            Console.WriteLine($"Inicialización y asignación");
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            int[] array3 = { 6, 7, 8, 9, 10 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"array3[{i}] : {array3[i]}");
            }

            Console.WriteLine("");
            Console.WriteLine($"Arreglo multi-dimensional");
            int[,] multidimensionalArrayOld = new int[2, 3];
            int[,] multidimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"multidimensionalArray[{i},{j}] : {multidimensionalArray[i, j]}");
                }
            }

            int[][] matrix = new int[6][];
            matrix[0] = new int[] { 1, 2, 3, 4, 5 };
            matrix[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            matrix[4] = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("");
            for (int i = 0; i < 6; i++)
            {
                if (matrix[i] == null) continue;

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine($"matrix[{i}][{j}] : {matrix[i][j]}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("String Array");

            string[] weekDays = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
        }
        public void ListSample()
        {
            Console.WriteLine("List");
            Console.WriteLine("====");

            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(7);

            numberList.ForEach(num =>
            {
                Console.WriteLine($"NumberList : {num}");
            });

            List<string> cities = new List<string>()
            {
                "Lima",
                "Villa el Salvador",
                "Rimac",
                "Callao",
                "Jesus Maria",
                "San Juan de Lurigancho",
                "Miraflores",
                "San Isidro",
                "Villa Maria del Triunfo"
            };

            Console.WriteLine("");
            cities.ForEach(city =>
            {
                Console.WriteLine($"Cities: {city}");
            });

            List<Person> people = new List<Person>
            {
                new Person{Name = "Erick",Age=38,Sex="M"},
                new Person{Name = "Jorge",Age=30,Sex="M"},
                new Person{Name = "Azucena",Age=22,Sex="F"},
                new Person{Name = "Jeniffer",Age=21,Sex="F"}
            };

            Console.WriteLine("");
            Console.WriteLine("Mujeres del salon de clase");
            people.Where(person => person.Sex == "F").ToList().ForEach(p => Console.WriteLine(p.Name));
            Console.WriteLine($"La suma de las edades es : {people.Sum(p => p.Age)}");
        }

        public void DictionarySample()
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine("==========");

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            people.Add("12345678", new Person { DNI = "12345678", Name = "Erick", Age = 38, Sex = "M" });
            people.Add("56428632", new Person { DNI = "56428632", Name = "Jorge", Age = 30, Sex = "M" });
            people.Add("41635163", new Person { DNI = "41635163", Name = "Azucena", Age = 22, Sex = "F" });
            people.Add("88382238", new Person { DNI = "88382238", Name = "Jeniffer", Age = 21, Sex = "F" });

            Console.WriteLine($"Azucena : {people.Where(kvp => kvp.Value.Name == "Azucena").Select(s => s.Key).First()} ");
            Console.WriteLine($"Key : 56428632, value {people["56428632"].Name}");

            people.Select(people => people.Key).ToList().ForEach(k => Console.WriteLine($"Key : {k}"));
        }

        public void SortedListSample()
        {
            Console.WriteLine("SortedList");
            Console.WriteLine("==========");

            SortedList<string, Person> people = new SortedList<string, Person>();

            people.Add("12345678", new Person { DNI = "12345678", Name = "Erick", Age = 38, Sex = "M" });
            people.Add("56428632", new Person { DNI = "56428632", Name = "Jorge", Age = 30, Sex = "M" });
            people.Add("41635163", new Person { DNI = "41635163", Name = "Azucena", Age = 22, Sex = "F" });
            people.Add("88382238", new Person { DNI = "88382238", Name = "Jeniffer", Age = 21, Sex = "F" });

            Console.WriteLine($"Azucena : {people.Where(kvp => kvp.Value.Name == "Azucena").Select(s => s.Key).First()} ");
            Console.WriteLine($"Key : 56428632, value {people["56428632"].Name}");

            people.Select(people => people.Key).ToList().ForEach(k => Console.WriteLine($"Key : {k}"));
        }
    }
}
