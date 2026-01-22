using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Evidence_01
{
    internal class Program
    {
        static string Name = "Shamsul Arefin Oitizzo";

        static void Main(string[] args)
        {
            ErrorHandaling();
            checkUnchecked();
            Console.WriteLine(ReturnMathod(540.12,154.12)+"\n");
            NameArguments(batch:69,Name:"Shamsul Arefin");
            OptionalParameters(1294499);
            Parameters(6,8);
            DeclaringVariableUsing_primitiveDataTypes();
            Prepostfix();
            ShortCircuit();
            Decition();
            Loops();
            Console.ReadKey();
        }

        private static void ErrorHandaling()
        {
            Console.WriteLine("-----------------------| ERROR HANDILING TRY-CATCH |-----------------------\n");
            try
            {
                int a = 50;
                int b = 10;
                int c = a / b;
                throw new Exception("Falat Error");
            }
            catch (DivideByZeroException dbzx)
            {
                Console.WriteLine(dbzx.Message);
            }
            catch (FormatException fx)
            {
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine();
        }

        private static void checkUnchecked()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Check Unchecked |------------------------\n");
            Console.WriteLine("Check       :\n");
            checked
            {
                try
                {
                    int a = int.MaxValue;
                    a++;
                    Console.WriteLine(a);
                }
                catch(OverflowException o)
                {
                    Console.WriteLine(o.Message);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();

                Console.WriteLine("\n");
                Console.WriteLine("UnCheck       :\n");
                unchecked
                {
                    int b = int.MaxValue;
                    b++;
                    Console.WriteLine(b);
                    Console.WriteLine();
                }
            }
        }

        private static double ReturnMathod(double a, double b)
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Return Mathod |------------------------\n");
            Console.WriteLine($"{a} and {b}");
            Console.WriteLine();

            return a + b;
        }

        private static void NameArguments(string Name, int batch)
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Name Arguments |------------------------\n");
            Console.WriteLine($"{Name} and R-{batch}");
            Console.WriteLine();
        }

        private static void OptionalParameters(int Roll, string Add="Patuakhali")
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Optional Parameters |------------------------\n");
            Console.WriteLine($"{Roll} and {Add}");
            Console.WriteLine();
        }

        private static void Parameters(int a, int b)
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Parameters |------------------------\n");
            Console.WriteLine($"{a} and {b}");
            Console.WriteLine();
        }

        private static void DeclaringVariableUsing_primitiveDataTypes()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Declaring, Naming & assigning variable, using Primitive data Types |------------------------\n");
            Console.WriteLine(" Primitive data Types       :\n");
            string a = "Oitizzo";
            int b = 10;
            decimal c = 45.25M;
            float d = 50.14F;
            long e = 98L;
            double f = .25;
            bool g = true;
            DateTime h = DateTime.Now;
            var i = new
            {
                j1 = "Shamsul Arefin",
                j2 = 185.25M,
                j3 = 1264499
            };
            Console.WriteLine($"{a},{b},{c},{d},{e},{f},{g},{h:T},{i.j1},{i.j2},{i.j3}");



            Console.WriteLine("\n");
            Console.WriteLine("Arithmetic Operators       :\n");
            int r = 20;
            int dr = 10;
            Console.WriteLine($"{r}+{dr}={r+dr}");
            Console.WriteLine($"{r}-{dr}={r - dr}");
            Console.WriteLine($"{r}/{dr}={r / dr}");
            Console.WriteLine($"{r}*{dr}={r * dr}");
            Console.WriteLine($"{r}%{dr}={r % dr}");



            Console.WriteLine("\n");
            Console.WriteLine("Scope variable, local variable, golobal variable     : \n");
            int localVariable = 12;
            {
                double ScopeVariable = 45217.120;
                Console.WriteLine($"{Name},{localVariable}, {ScopeVariable}");
            }


        }

        private static void Prepostfix()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Prefix & Postfix |------------------------\n");
            Console.WriteLine("Prefix       :\n");
                int e = 5;
            Console.WriteLine(++e);
            Console.WriteLine();



            Console.WriteLine("Postfix       :\n");
            Console.WriteLine(e++);
            Console.WriteLine();
        }

        private static void ShortCircuit()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| Short Circuit |------------------------\n");
            Console.WriteLine("AND       :\n");
            int d = 19;
            bool Id= true;
            if (d>=19 && Id)
            {
                Console.WriteLine("You Are Pass This Enter");
            }
            else
            {
                Console.WriteLine("You Are Not A Valid Person");
            }


            Console.WriteLine("\n");
            Console.WriteLine("OR       :\n");
            if (d >= 20 || Id)
            {
                Console.WriteLine("You Are Pass This Enter");
            }
            else
            {
                Console.WriteLine("You Are Not A Valid Person");
            }
        }

        private static void Decition()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| DECITION |------------------------\n");
            Console.WriteLine("If-Else       :\n");
            if(DateTime.Now.Hour>12)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("Good AfterNoon");
            }


            Console.WriteLine("\n");
            Console.WriteLine("Switch Case      :\n");
            switch (DateTime.Now.Hour > 12)
            {
                case true:
                    Console.WriteLine("Good Morning");
                    break;
                case false:
                    Console.WriteLine("Good Evening");
                    break ;
                default:
                    Console.WriteLine("Have a Nice Day");
                    break;
            }
        }

        private static void Loops()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------| LOOPS |------------------------\n");
            Console.WriteLine("While Loops       :\n");
            int a = 1;
            while (a<=10)
            {
                Console.Write($"{a}\t");
                a++;
            }


            Console.WriteLine("\n");
            Console.WriteLine("Do While Loops       :\n");
            int b = 1;
            do
            {
                Console.Write($"{b}\t");
                b++;
            }
            while (b <= 10);



            Console.WriteLine("\n");
            Console.WriteLine("For Loops       :\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}\t");
            }



            Console.WriteLine("\n");
            Console.WriteLine("For-Each Loops       :\n");
            int[] c= {1,2,3,4,5,6,7,8,9,10};
            foreach (int i in c)
            {
                Console.Write($"{i}\t"); 
            }
        }
    }
}
