using System;
using Hookah;

namespace Multifile
{
    class Program
    {
        static void Main(string[] args)
        {
            Name obj = new Name();

            Name obj2 = new Name();

            string model = obj.GetModel("Alpha X");
            string type = obj.TypeHookah("Настольный");
            string material = obj.MaterialHookah("Нержавеющая сталь");

            string model2 = obj2.GetModel("Mamay изумруд");
            string type2 = obj2.TypeHookah("Напольный");
            string material2 = obj2.MaterialHookah("Композитные материалы");

            Console.WriteLine(model);
            Console.ReadLine();

        }
    }
}
