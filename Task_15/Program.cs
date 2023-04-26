Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (day < 1 || day >7)
{
    Console.WriteLine("Это не день недели");
}
else
{
    Console.WriteLine("Это не выходной день");
}