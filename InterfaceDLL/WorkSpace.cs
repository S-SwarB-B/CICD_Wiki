using DDL_Unit_test_CICD_Wiki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDLL
{
    internal class WorkSpace
    {
        public void WorkMass(ref int screenNav, int[] mass)
        {
            ProgramDLL program = new ProgramDLL();
            NavigateClass nav = new NavigateClass();

            int[] newMass = new int[mass.Length];

            if (screenNav == 2)
            {
                int _count = Convert.ToInt32(Console.ReadLine());

                if (_count != 3)
                {
                    newMass = program.SortArray(mass, _count);

                    for (int i = 0; i < newMass.Length; i++)
                    {
                        Console.WriteLine(newMass[i]);
                    }
                }
                else { screenNav = 1; nav.Navigate(screenNav, mass); }
            }
            else if (screenNav == 3)
            {
                int _count = Convert.ToInt32(Console.ReadLine());
                if (_count == 1)
                {
                    Console.Write("Введите нижнюю границу: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите верхнюю границу: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    newMass = program.FiltrMass(mass, a, b);
                    for (int i = 0; i < newMass.Length; i++)
                    {
                        Console.WriteLine(newMass[i]);
                    }
                }
                else if(_count == 2)
                { screenNav = 4; nav.Navigate(screenNav, mass); }
                else if(_count == 3)
                { screenNav = 1; nav.Navigate(screenNav, mass); }
            }
            else if (screenNav == 4)
            {
                int _count = Convert.ToInt32(Console.ReadLine());
                if(_count != 3)
                {
                   newMass = program.FiltrMass(mass, _count);

                   for (int i = 0; i < newMass.Length; i++)
                   {
                       Console.WriteLine(newMass[i]);
                   }
                }
                else { screenNav = 3; nav.Navigate(screenNav, mass);}
            }
            else if (screenNav == 5)
            {
                try
                {
                    int _count = Convert.ToInt32(Console.ReadLine());
                    if (_count != 3)
                    {
                        Console.Write("Введите число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = program.PoiskMass(mass, _count, b);
                        Console.WriteLine(c);
                    }
                    else { screenNav = 1; nav.Navigate(screenNav, mass); }
                }
                catch { screenNav = 5; }
            }
        }
    }
}