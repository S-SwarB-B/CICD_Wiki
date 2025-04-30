using InterfaceDLL;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

NavigateClass nav = new NavigateClass();
WorkSpace work = new WorkSpace();
int screenNav = 1;
int[] mass = { 0 };
int L = 0;
try
{
    Console.Write("Введите длинну массива: ");
    L = Convert.ToInt32(Console.ReadLine());
    mass = new int[L];
}
catch
{
    Console.WriteLine("Ошибка с массивом(возможно вместо цифр введены буквы)");
}

try
{
    int i = int.MaxValue;

    Console.WriteLine("Массив:");
    for (int j = 0; j < L; j++)
    {
        Console.Write($"{j+1} - ");
        mass[j] = Convert.ToInt32(Console.ReadLine());
    }

    while (i == int.MaxValue)
    {
        nav.Navigate(screenNav, mass);

        work.WorkMass(ref screenNav, mass);

        nav.NewScreen(ref screenNav, ref i);                
    }
}
catch
{
    if(screenNav != 1)
    {
        nav.Navigate(screenNav, mass);
    }
}