// See https://aka.ms/new-console-template for more information
using Homework13_net;
using System;

Console.WriteLine("Exercise 2");



ArithmeticOperation addition = ArithmeticOperations.Add;
ArithmeticOperation subtraction = ArithmeticOperations.Subtract;
ArithmeticOperation multiplication = ArithmeticOperations.Multiply;

// Ввод чисел
Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

// Выполнение операций
Console.WriteLine($"Addition result: {ArithmeticOperations.PerformOperation(addition, num1, num2)}");
Console.WriteLine($"Subtraction result: {ArithmeticOperations.PerformOperation(subtraction, num1, num2)}");
Console.WriteLine($"Result of multiplication: {ArithmeticOperations.PerformOperation(multiplication, num1, num2)}");
Console.ReadLine();
Console.WriteLine("Exercise 3");
Predicate<int> isEven = ArithmeticOperations.IsEven;//Создание делегата для проверки нчетности
Predicate<int> isOdd = ArithmeticOperations.IsOdd;// Создание делегата для проверки нечетности
Predicate<int> isPrime = ArithmeticOperations.IsPrime;// Создание делегата для проверки простого числа
Predicate<int> isFibonacci = ArithmeticOperations.IsFibonacci;// Создание делегата для проверки числа Фибоначчи
Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} is even: {isEven.Invoke(number)}");
Console.WriteLine($"{number} is odd: {isOdd.Invoke(number)}");
Console.WriteLine($"{number} is a prime number: {isPrime.Invoke(number)}");
Console.WriteLine($"{number} is a Fibonacci number: {isFibonacci.Invoke(number)}");

Console.ReadLine();

Console.WriteLine("Exercise 4");

Console.WriteLine($"Addition result: {addition.Invoke(num1, num2)}");
Console.WriteLine($"ubtraction result: {subtraction.Invoke(num1, num2)}");
Console.WriteLine($"Result of multiplication: {multiplication.Invoke(num1, num2)}");

Console.ReadLine();
    