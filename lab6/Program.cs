using System;
class Calculator{
    public int Add(int a, int b){
        return a + b;
    }
    public int Subtract(int a, int b){
        return a - b;
    }
    public int Multiply(int a, int b){
        return a * b;
    }
    public int Divide(int a, int b){
        if (b == 0){
            Console.Write("Не можна ділити на нуль");
            return 0;
        }
        return a / b;
    }
    public double Power(int a, int b){
        return Math.Pow(a, b);
    }
    public int Modulus(int a, int b){
        return a % b;
    }
}
class Program{
    static void Main(){
        Calculator calc = new Calculator();
        int a, b, choice;
        Console.Write("Введіть перше число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть операцію, яку ви хочете використовувати з {0} and {1}:", a, b);
        Console.Write("\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Raise to power\n6. Modulus\n");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1:
                int AddResult = calc.Add(a, b);
                Console.Write("{0} + {1} = {2}", a, b, AddResult);
                break;
            case 2:
                int SubtractResult = calc.Subtract(a, b);
                Console.Write("{0} - {1} = {2}", a, b, SubtractResult);
                break;
            case 3:
                int MultiplyResult = calc.Multiply(a, b);
                Console.Write("{0} * {1} = {2}", a, b, MultiplyResult);
                break;
            case 4:
                double DivideResult = calc.Divide(a, b);
                Console.Write("{0} / {1} = {2}", a, b, DivideResult);
                break;
            case 5:
                double PowResult = calc.Power(a, b);
                Console.Write("{0} ^ {1} = {2}", a, b, PowResult);
                break;
            case 6:
                double ModResult = calc.Modulus(a, b);
                Console.Write("{0} % {1} = {2}", a, b, ModResult);
                break;
            default:
                Console.WriteLine("Invalid choice of operation");
                break;
        }
        Console.ReadKey();
    }
}
