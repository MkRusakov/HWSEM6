// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
double[] CreateArray (int howNumbers)
{
    double[] newArray = new double[howNumbers];
    for (int i = 0; i < howNumbers; i++)
    {
        Console.Write("Введите число:");
        newArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return newArray;
}
void PrintArray (double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void GreaterZero (double[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) count++;
    }
    Console.Write($"Количество цифр больше нуля - {count}");
}
double[] newArray = CreateArray(8);
PrintArray(newArray);
GreaterZero(newArray);
