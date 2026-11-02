// Console.WriteLine("=== try-catch: FormatException ===");

// try
// {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());
//     Console.WriteLine($"Вы ввели: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введено не число!");
// }

// Console.WriteLine("Программа продолжает работу как ни в чём не бывало");
// Console.WriteLine();
// Console.WriteLine("=== ex.Message ===");

// try
// {
//     int[] numbers = { 1, 2, 3 };
//     Console.WriteLine(numbers[10]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine($"Произошла ошибка: {ex.Message}");
// }

// Console.WriteLine();
// Console.WriteLine("=== Несколько catch ===");

// Console.Write("Введите делитель: ");
// try
// {
//     int divisor = int.Parse(Console.ReadLine());
//     int result = 100 / divisor;
//     Console.WriteLine($"Результат: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: это не число");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Ошибка: нельзя делить на ноль");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
// }
// Console.WriteLine();
// Console.WriteLine("=== finally ===");

// try
// {
//     Console.WriteLine("Пытаемся выполнить операцию...");
//     int[] numbers = { 1, 2, 3 };
//     Console.WriteLine(numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Этот блок выполнится в любом случае");
// }

// Console.WriteLine();
// Console.WriteLine("=== finally без ошибки ===");

// try
// {
//     Console.WriteLine("Операция без ошибок");
// }
// finally
// {
//     Console.WriteLine("И здесь finally тоже сработал");
// }
// Console.WriteLine();
// Console.WriteLine("=== throw ===");

// try
// {
//     double result = CalculateSquareRoot(987654);
//     Console.WriteLine(result);
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }

// double CalculateSquareRoot(double number)
// {
//     if (number < 0)
//     {
//         throw new ArgumentException("Число не может быть отрицательным");
//     }
//     return Math.Sqrt(number);
// }
// Console.WriteLine();
// Console.WriteLine("=== Собственное исключение ===");

// try
// {
//     Withdraw(1000, 1500);
// }
// catch (NegativeBalanceException ex)
// {
//     Console.WriteLine($"Операция отклонена: {ex.Message}");
// }

// Withdraw(1000, 400);

// void Withdraw(double balance, double amount)
// {
//     if (amount > balance)
//     {
//         throw new NegativeBalanceException($"Недостаточно средств: на счёте {balance}, а нужно снять {amount}");
//     }
//     Console.WriteLine($"Снято {amount}, остаток {balance - amount}");
// }

// class NegativeBalanceException : Exception
// {
//     public NegativeBalanceException(string message) : base(message)
//     {
//     }
// }
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// do
// {
//     Console.WriteLine("1. Вычислить");
//     Console.WriteLine("0. Выход");
//     Console.Write("Выберите действие: ");
//     string t = Console.ReadLine();
//     if (t == "0")
//     {
//         break;
//     }
//     try
//     {
//         Console.WriteLine("Введите первое число");
//         int r = int.Parse(Console.ReadLine());
//         Console.Write("Введите второе число: ");
//         int b = int.Parse(Console.ReadLine());
//         Console.Write("Введите операцию (+, -, *, /): ");
//         string op = Console.ReadLine();
//         int res = 0;

//     switch (op)
//     {
//         case "+":
//         res = r + b;
//         break;
//         case "-":
//         res = r - b;
//         break;
//         case"*":
//         res = r * b;
//         break;
//         case"/":
//         res = r / b;
//         break;
//         default:throw new UnknownOperationException(
//                     $"Неизвестная операция: {op}");

//     }
//     Console.WriteLine(res);}
//     catch (FormatException)
//     {
//         Console.WriteLine("Ошибка: необходимо вводить целые числа!");
//     }
//     catch (DivideByZeroException)
//     {
//         Console.WriteLine("Ошибка: нельзя делить на ноль!");
//     }
//     catch (UnknownOperationException ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
//     finally
//     {
//         Console.WriteLine("------------------------");
//     }
// } while (true);

// class UnknownOperationException : Exception
// {
//     public UnknownOperationException(string message) : base(message)
//     {
//     }
// }
// int[] n = {1, 4, 7};

// try
// {
// Console.WriteLine("Введите индекс");
// int y = int.Parse(Console.ReadLine());
// Console.WriteLine($"Значение: {n[y]}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: нужно ввести целое число!");
// }
// catch (IndexOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: такого индекса нет!");
// }

// try
// {
//     Console.WriteLine("Введите возраст");
//     int f = int.Parse(Console.ReadLine());
//     CheckAge(f);
//     Console.WriteLine("Возраст указан верно");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите возраст числом!");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// void CheckAge(int age)
//     {
//         if (age < 0 || age > 120)
//         {
//             throw new ArgumentException("возраст только от 0 до 120");
//         }
//     }
double bal = 1000;

while (true)
{
    Console.WriteLine("=== БАНК ===");
    Console.WriteLine("1. Пополнить счёт");
    Console.WriteLine("2. Снять деньги");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите действие: ");

    string act = Console.ReadLine();

    if (act == "0")
    {
        break;
    }

    try
    {
        Console.Write("Введите сумму: ");

        double sum = double.Parse(Console.ReadLine());

        if (act == "1")
        {
            Deposit(ref bal, sum);
        }
        else if (act == "2")
        {
            Withdraw(ref bal, sum);
        }
        else
        {
            Console.WriteLine("Неизвестная команда!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: введите сумму числом!");
    }
    catch (InvalidAmountException ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    catch (InsufficientFundsException ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    finally
    {
        Console.WriteLine($"Текущий баланс: {bal}");
        Console.WriteLine("------------------------");
    }
}

void Deposit(ref double bal, double sum)
{
    if (sum <= 0)
    {
        throw new InvalidAmountException(
            "Сумма пополнения должна быть больше нуля!"
        );
    }

    bal += sum;

    Console.WriteLine("Счёт успешно пополнен!");
}

void Withdraw(ref double bal, double sum)
{
    if (sum <= 0)
    {
        throw new InvalidAmountException(
            "Сумма снятия должна быть больше нуля!"
        );
    }

    if (sum > bal)
    {
        throw new InsufficientFundsException(
            "На счёте недостаточно средств!"
        );
    }

    bal -= sum;

    Console.WriteLine("Деньги успешно сняты!");
}

class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message)
    {
    }
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}