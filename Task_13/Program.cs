Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2)
{
    Console.WriteLine($"Третья цифра числа - {number_text[2]}");
} 
else
{
    Console.WriteLine("Третьей цифры нет");
}