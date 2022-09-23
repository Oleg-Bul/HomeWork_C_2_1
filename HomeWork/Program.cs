void palindromeCheck()
{
int NumberOne(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }
    return num;
}
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (number < 0)
    number *= -1;

if (number > 9999 && number < 100000)
{
    int x = number % 100;
    int y = NumberOne(number, 2);
    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

else
{
    Console.WriteLine("Введите число больше 9999 и меньше 100000");
}
}
palindromeCheck();
void distanceBetweenPoints()
{
    Console.WriteLine("Введите координаты X точки A");
    int aPointX = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты Y точки A");
    int aPointY = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты Z точки A");
    int aPointZ = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты X точки B");
    int bPointX = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты Y точки B");
    int bPointY = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты Z точки B");
    int bPointZ = int.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow((bPointX - aPointX),2)+Math.Pow((bPointY - aPointY),2)+Math.Pow((bPointZ - aPointZ),2));
    Console.WriteLine("Расстояние между точками  " + distance);
}
distanceBetweenPoints();
void CubeNumbers()
{
    Console.WriteLine("Введите число");
    int numberN = int.Parse(Console.ReadLine());
    int index = 1;
    while (index < numberN+1)
    {
        Console.WriteLine(Math.Pow(index,3));
        index++;
    }
}
CubeNumbers();