try
{
    Console.Write("Введите трехзначное число: ");
    int x = int.Parse(Console.ReadLine());
        int hundreds = x / 100;
        int tens = (x / 10) % 10;
        int units = x % 10;

        int z = tens * 100 + hundreds * 10 + units;

        Console.WriteLine("Новое число: " + z);
}
catch
{
    Console.WriteLine("Ошибка: Введите корректное число.");
}