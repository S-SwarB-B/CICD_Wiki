namespace DDL_Unit_test_CICD_Wiki
{
    public class ProgramDLL
    {
        public int[] SortArray(int[]mass, int typeSort) //Метод сортировки массива
        {
            int[] result = (int[])mass.Clone();
            if (typeSort == 1) //Если typeSort == 1, то массив сортируется по возрастанию
            {
                Array.Sort(result);
            }
            else if (typeSort == 2) //Если typeSort == 2, то по убыванию
            {
                Array.Sort(result);
                Array.Reverse(result);
            }
            return result;
        }

        public int[] FiltrMass(int[] mass, int a, int b) //Фильтрация массива по числам между границами
        {
            List<int> newMass = new List<int>(); //Создание листа newMass, в который будут помещаться элементы между a и b
            for (int i = 0; i < mass.Length; i++) 
            { 
                if ((mass[i] > a) && (mass[i] < b))
                {
                    newMass.Add(mass[i]);
                }
            }
            return newMass.ToArray(); //Преобразование листа в массив
        }

        public int[] FiltrMass(int[] mass, int c) //Фильтрация массива по четным и нечетным числам
        {
            List<int> newMass = new List<int>(); //Создание листа
            for (int i = 0; i < mass.Length; i++)
            {
                if (c == 1 && mass[i] % 2 == 0) //Четные числа
                {
                    newMass.Add(mass[i]);
                }
                else if (c == 2 && mass[i] % 2 != 0) //Нечетные числа
                {
                    newMass.Add(mass[i]);
                }
            }
            return newMass.ToArray(); //Преобразование листа в массив
        }

        public int PoiskMass(int[] mass, int a, int b) //Реализация поиска в массиве
        {
            int _char = 0; //Создание числа, которое будет возвращено
            if (a == 1) //Индекс первого вхождения элемента в массив
            {
                _char = Array.IndexOf(mass,b);
            }
            else if (a == 2) //Элемент с индексом
            {
                _char = mass[b];
            }
            return _char;
        }
    }
}
