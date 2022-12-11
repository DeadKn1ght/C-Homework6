// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

int MoreThenZero(int[] array)
{
    int SummPositive = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > 0) SummPositive++;
    }
    return SummPositive;
}

System.Console.WriteLine("How much numbers you wohn to input? :");
int numbers = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Input {numbers} numbers you like :");

int[] array = new int[numbers];
string numb;
for (int i = 0; i < numbers; i++)
{
    numb = Console.ReadLine();
    array[i] = Convert.ToInt32(numb);
}
int moreZero = MoreThenZero(array);
System.Console.WriteLine($"You input {moreZero} numbers more than 0");