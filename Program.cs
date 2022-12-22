/*Console.WriteLine("Введи первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int B = int.Parse(Console.ReadLine()!);
int Max = 0;
if (A > B)
{
    Console.WriteLine($"число {A} больше числа {B}");
Console.WriteLine($"Max={A}");
}
if (A < B)
{ 
    Console.WriteLine($"Число {B} больше числа {A}");
Console.WriteLine($"Max={B}");
}*/


/*Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine($"число {num1} больше числа {num2}");
    Console.Write($"{num1}");
}
else 
{
    Console.WriteLine($"число {num2} больше числа {num1}");
    Console.Write($"{num2}");
}
if (num2 > num3)
{
    Console.WriteLine($"число {num2} больше числа {num3}");
    Console.Write($"{num2}");
}
else 
{
    Console.WriteLine($"число {num3} больше числа {num2}");
    Console.Write($"{num3}"); 
}
if (num3 > num1)
{
    Console.WriteLine($"число {num3} больше числа {num1}");
    Console.Write($"{num3}");


}
else 
{
    Console.WriteLine($"число {num1} больше числа {num3}");
    Console.Write($"{num1}");
}
*/


/*Console.WriteLine("Введи число: ");
int G = int.Parse(Console.ReadLine()!);
if (G%2!=0)
{
    Console.WriteLine($"число {G} нечетное");

}

else
{
    Console.WriteLine($"число {G} четное");
}*/


Console.WriteLine("Введи число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 =1;

while(N1 <= N){
    if(N1%2==0)
    Console.Write($"{N1}");
    N1++;
}



