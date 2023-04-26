Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length != 3)
{
    Console.WriteLine("Это не трехзначное число!");
}
else
{
    Console.WriteLine($"Вторая цифра этого числа: {number/10%10}");
}
