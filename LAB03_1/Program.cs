Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {Math.Abs(num1 - num2)}");
Console.WriteLine($"Произведение: {num1 * num2}");
Console.WriteLine($"Среднее арифметическое: {(num1 + num2) / 2}"); 
       