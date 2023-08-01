// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = Prompt("Введите число А:");
int b = Prompt("Введите число В:");

int Pow = InPower(a,b);

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int InPower(int num1, int num2)
{
    int result = 1;

    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }

    return result;
}

bool ExpCheck(int exponent)
{
    if(exponent < 0)
    {
        Console.WriteLine("Степень не должна быть отрицательной!");
        return false;
    }
    return true;
}

if(ExpCheck(b))
{
    Console.WriteLine($"Число A = {a} в степени B = {b} -> {InPower(a,b)}");
}