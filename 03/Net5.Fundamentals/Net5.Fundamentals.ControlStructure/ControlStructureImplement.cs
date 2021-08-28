using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.ControlStructure
{
    public class ControlStructureImplement
    {
        public void IfStructure()
        {
            int precio = 300;

            Console.WriteLine("If Structure");
            Console.WriteLine("============");
            Console.WriteLine("Ingrese un precio (Entero) : ");
            precio = Convert.ToInt32(Console.ReadLine());

            if(precio > 100)
            {
                Console.WriteLine("El precio es mayor que 100");
            }
        }

        public void IfElseIfStructure()
        {
            int precio = 300;

            Console.WriteLine("If Else If Structure");
            Console.WriteLine("=====================");
            Console.WriteLine("Ingrese un precio (Entero) : ");
            precio = Convert.ToInt32(Console.ReadLine());

            if (precio == 100)
            {
                Console.WriteLine("El precio es 100");
            }else if(precio == 200)
            {
                Console.WriteLine("El precio es 200");
            }
            else
            {
                Console.WriteLine("El precio no es ni 100 ni 200");
            }
        }

        public void IfNested()
        {
            int precio = 300;

            Console.WriteLine("If Nested");
            Console.WriteLine("=========");
            Console.WriteLine("Ingrese un precio (Entero) : ");
            precio = Convert.ToInt32(Console.ReadLine());

            if (precio >= 0)
            {
                if(precio > 100)
                {
                    Console.WriteLine("Es un precio de oferta");
                }
                else
                {
                    Console.WriteLine("Es un precio de rebaja");
                }
            }            
            else
            {
                Console.WriteLine("El precio no puede ser negativo");
            }
        }

        public void ForStructure()
        {
            Console.WriteLine("For Structure");
            Console.WriteLine("=============");
            Console.WriteLine("Ingrese la cantidad de repeticiones (Entero) : ");
            
            int limit = 0;
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine($"i = {i}");
            }
        }

        public void WhileStructure()
        {
            int stock = 0;
            int peopleCount = 0;
            int deliveryQuantity = 0;

            Console.WriteLine("While Structure");
            Console.WriteLine("===============");
            Console.WriteLine("Ingrese el stock inicial (Entero) : ");

            stock = Convert.ToInt32(Console.ReadLine());

            while (stock >= 10)
            {
                Console.WriteLine("Ingrese cantidad a entregar (Entero) : ");
                deliveryQuantity = Convert.ToInt32(Console.ReadLine());

                if(stock >= deliveryQuantity)
                {
                    stock = stock - deliveryQuantity;
                    peopleCount++;
                }
            }

            Console.WriteLine($"Stock Final = {stock}");
            Console.WriteLine($"Cantidad de personas atendidas = {peopleCount}");
        }
        public void DoWhileStructure()
        {
            int score = 0;
            
            Console.WriteLine("Do While Structure");
            Console.WriteLine("==================");

            do
            {
                Console.WriteLine("Ingrese su nota (Entero) : ");
                score = Convert.ToInt32(Console.ReadLine());

                if (score >= 11 && score <= 20)
                {
                    Console.WriteLine("Aprobaste :)");
                }
                else if (score >= 0 && score <= 10)
                {
                    Console.WriteLine("Desaprobaste :(");
                }
                else
                {
                    Console.WriteLine("Es una nota invalida");
                }
            } while (score!=0);
        }
        public void SwitchStructure()
        {
            int numberDay;
            string day;

            Console.WriteLine("Switch Structure");
            Console.WriteLine("================");
            Console.WriteLine("Ingrese el día de la semana laborable (0 - 5) :");
            numberDay = Convert.ToInt32(Console.ReadLine());

            switch (numberDay)
            {
                case 1:
                    day = "Lunes";
                    break;
                case 2:
                    day = "Martes";
                    break;
                default:
                    day = "No es un día laborble";
                    break;
            }
            Console.WriteLine(day);
            
        }
        public void BreakCommand()
        {
            int limit;
            Console.WriteLine("Break Command");
            Console.WriteLine("=============");
            Console.WriteLine("Ingrese la cantidad de repeticiones (Entero):");
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine($"i = {i}");
            }

        }

        public void ContinueCommandInFor()
        {
            int limit;
            Console.WriteLine("Continue Command In For");
            Console.WriteLine("=======================");
            Console.WriteLine("Ingrese la cantidad de repeticiones (Entero):");
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine($"i = {i}");
            }

        }

        public void ContinueCommandInWhile()
        {
            int limit;
            Console.WriteLine("Continue Command In While");
            Console.WriteLine("=========================");
            Console.WriteLine("Ingrese la cantidad de repeticiones (Entero):");
            limit = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while(i <= limit)
            {
                i++;

                if (i < 5)
                {
                    continue;
                }
                Console.WriteLine($"i = {i}");
            }

        }

        public void GoToCommandInSwitch()
        {
            int cost = 0;
            Console.WriteLine("GoTo Command in Switch");
            Console.WriteLine("======================");
            Console.WriteLine("Tamaños de cafe : ");
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Grande");
            Console.WriteLine("3 = Venti");
            Console.Write("Por favor ingrese su eleccion : ");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    //cost = costo + 25;
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Selección inválida");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine($"Por favor inserte {cost} soles");
            }

            Console.WriteLine("Gracias por su compra.");
        }
        public void ForEachStructure()
        {
            Console.WriteLine("For Each Structure");
            Console.WriteLine("==================");
            Console.Write("Ingrese la cantidad de elementos (Entero) : ");

            int peopleCount = Convert.ToInt32(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                people.Add(new Person
                {
                    Nombre = $"First Name- {i}",
                    ApellidoPaterno = $"Last Name- {i}",
                    ApellidoMaterno = $"Sur Name- {i}",
                });
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"Complete Name : {person.Nombre} {person.ApellidoPaterno} {person.ApellidoMaterno}");
            }
        }
        public void TryCatchStructure()
        {
            int dividendo = 100;
            int divisor = 0;
            int resultado = 0;

            try
            {
                Console.WriteLine("Try Catch Structure");
                Console.WriteLine("===================");
                Console.Write("Ingrese Dividendo (Entero) : ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Divisor (Entero) : ");
                divisor = Convert.ToInt32(Console.ReadLine());

                resultado = dividendo / divisor;

                Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
        public void TryCatchFinallyStructure()
        {
            int dividendo = 100;
            int divisor = 0;
            int resultado = 0;
            bool succeedOperation = false;

            try
            {
                Console.WriteLine("Try Catch Structure");
                Console.WriteLine("===================");
                Console.Write("Ingrese Dividendo (Entero) : ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Divisor (Entero) : ");
                divisor = Convert.ToInt32(Console.ReadLine());

                resultado = dividendo / divisor;
                Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
                succeedOperation = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                succeedOperation = false;
            }
            finally
            {
                if (succeedOperation)
                {
                    Console.WriteLine($"La operación fue exitosa :)");
                }
                else
                {
                    Console.WriteLine($"La operación no fue exitosa :(");
                }
            }
        }

    }
}
