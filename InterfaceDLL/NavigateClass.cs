using DDL_Unit_test_CICD_Wiki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDLL
{
    internal class NavigateClass
    {
        //Главный экран: 1
        //Сортировка: 2
        //Фильтрация: 3 4
        //Поиск: 5
        public void Navigate(int screenNav, int[] mass)
        {
            if (screenNav == 1) //Главный экран
            {
                Console.Clear();
                for(int i = 0; i < mass.Length; i++) 
                { 
                    Console.WriteLine($"{i} - {mass[i]}");
                }
                Console.Write("Что вы хотите сделать с массивом?\n" +
                              "1 - Провести сортировку\n" +
                              "2 - Провести фильтрацию\n" +
                              "3 - Провести поиск\n" +
                              "4 - Ничего(выход)\n" +
                              "Ваше действие: ");
            }
            if (screenNav == 2) //Сортировка массива
            {
                Console.Clear();
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine($"{i} - {mass[i]}");
                }
                Console.Write("Как вы хотите отсортировать массив?\n" +
                              "1 - По возрастанию\n" +
                              "2 - По убыванию\n" +
                              "3 - Вернуться назад\n" +
                              "Ваше действие: ");
            }
            if (screenNav == 3) //Фильтрация массива(главная)
            {
                Console.Clear();
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine($"{i} - {mass[i]}");
                }
                Console.Write("Как вы хотите провести фильтрацию?\n" +
                              "1 - Элементы между числами a и b\n" +
                              "2 - Четные или нечетные числа\n" +
                              "3 - Вернуться назад\n" +
                              "Ваше действие: ");
            }
            if (screenNav == 4) //Фильтрация массива (выбран 2 вариант)
            {
                Console.Clear();
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine($"{i} - {mass[i]}");
                }
                Console.Write("Как вы хотите провести фильтрацию?\n" +
                              "1 - Фильрация по четным числам\n" +
                              "2 - Фильтрация по нечетным числам\n" +
                              "3 - Вернуться назад\n" +
                              "Ваше действие: ");
            }
            if (screenNav == 5) //Поиск в массиве
            {
                Console.Clear();
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine($"{i} - {mass[i]}");
                }
                Console.Write("Как вы хотите провести поиск в массиве?\n" +
                              "1 - По первому вхождению элемента в массив(вводится число, возвращается индекс числа)\n" +
                              "2 - По индексу(вводится индекс, возвращается число)\n" +
                              "3 - Вернуться назад\n" +
                              "Ваше действие: ");
            }
        }
        public int NewScreen(ref int screenNav, ref int i) //Реализация переключения между экранами
        {
            ProgramDLL program = new ProgramDLL();
            WorkSpace workSpace = new WorkSpace();


            try
            {
                int _count = Convert.ToInt32(Console.ReadLine());

                if ((screenNav == 1 && _count == 4))
                {
                    i = 0;
                    return _count;
                }
                else if (screenNav == 1 && _count == 1)
                {
                    screenNav = 2;
                    return _count;
                }
                else if (screenNav == 1 && _count == 2)
                {
                    screenNav = 3;
                    return _count;
                }
                else if (screenNav == 3 && _count == 2)
                {
                    screenNav = 4;
                    return _count;
                }
                else if (screenNav == 1 && _count == 3)
                {
                    screenNav = 5;
                    return _count;
                }
                else { return 0; }
            }
            catch { screenNav = screenNav;
                return 0;
            }
        }
    }
}
