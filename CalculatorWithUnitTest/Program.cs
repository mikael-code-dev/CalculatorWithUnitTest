using CalculatorWithUnitTest;

init();
Start();
RunProgram();

void RunProgram()
{
    double num1;
    double num2;
    double[] numsDouble;
    decimal num3;
    decimal num4;
    double? result = null;
    decimal? resultDivision = null;

    while (true)
    {
        Console.Clear();
        Menu();
        Message(" :> ", false);
        switch(Console.ReadLine())
        {
            case "1":
                num1 = GetUserinputSingleNum(" Enter first number: ");
                num2 = GetUserinputSingleNum(" Enter second number: ");
                result = MathFunctions.Addition(num1, num2);
                Message($" {num1} + {num2} = {result}");
                break;

            case "2":
                numsDouble = GetUserinputMultiDoubleNums(" Enter your numbers separated with a space: ");
                if (numsDouble.Length > 0)
                {
                    result = MathFunctions.Addition(numsDouble);
                }
                if (numsDouble.Length > 0)
                {
                    for (int i = 0; i < numsDouble.Length; i++)
                    {
                        if (i == numsDouble.Length - 1)
                        {
                            Message($" {numsDouble[i]}", false);
                        }
                        else
                        {
                            Message($" {numsDouble[i]} +", false);
                        }
                    }
                    Message($" = {result}", false);
                    Message("");
                }
                break;

            case "3":
                num1 = GetUserinputSingleNum(" Enter first number: ");
                num2 = GetUserinputSingleNum(" Enter second number: ");
                result = MathFunctions.Subtraction(num1, num2);
                Message($" {num1} - {num2} = {result}");
                break;

            case "4":
                numsDouble = GetUserinputMultiDoubleNums(" Enter your numbers separated with a space: ");
                if (numsDouble.Length > 0)
                {
                    result = MathFunctions.Subtraction(numsDouble);
                }
                if(numsDouble.Length > 0)
                {
                    for (int i = 0; i < numsDouble.Length; i++)
                    {
                        if (i == numsDouble.Length - 1)
                        {
                            Message($" {numsDouble[i]}", false);
                        }
                        else
                        {
                            Message($" {numsDouble[i]} -", false);
                        }
                    }
                    Message($" = {result}", false);
                    Message("");
                }
                break;

            case "5":
                num1 = GetUserinputSingleNum(" Enter first number: ");
                num2 = GetUserinputSingleNum(" Enter second number: ");
                result = MathFunctions.Multiply(num1, num2);
                Message($" {num1} * {num2} = {result}");
                break;

            case "6":
                num3 = GetUserinputDecimalNum(" Enter first number: ");
                num4 = GetUserinputDecimalNum(" Enter second number: ");
                resultDivision = MathFunctions.Division(num3, num4);
                if (resultDivision.HasValue)
                {
                    Message($" {num3} / {num4} = {resultDivision}");
                }
                break;

            case "7":
                return;

            default:
                //Message(" Something went wrong, try again!");
                //Console.ReadKey();
                continue;
        }

        Message(" Press any key to continue...");
        Message(" ");
        Console.ReadKey();
    }
}

double[] GetUserinputMultiDoubleNums(string prompt)
{
    Message(prompt);
    Message(" :> ", false);
    //double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
    
    var resultList = new List<double>();

    try
    {
            resultList = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
    }
    catch (FormatException)
    {
        Message(" You can only enter numbers, try again!");
    }

    double[] result = new double[resultList.Count];
    result = resultList.ToArray();

    return result;
}

decimal GetUserinputDecimalNum(string prompt)
{
    Message(prompt);
    Message(" :> ", false);
    decimal num;
    while(!decimal.TryParse(Console.ReadLine(), out num))
    {
        Message(" You have to enter a number, try again!");
        Message(" :> ", false);
    }
    return num;
}

double GetUserinputSingleNum(string prompt)
{
    Message(prompt, false);
    double num;
    while(!double.TryParse(Console.ReadLine(), out num))
    {
        Message(" You have to enter a number, try again!");
        Message(" :> ", false);
    }
    return num;
}

void Start()
{
    Message(" **********   CALCULATOR WITH TEST   **********");
    Message("\n Make simple calculations with this calculator fast & easy!");
    Message(" Press any key to start calculating:");
    Message(" ", false);
    Console.ReadKey();
}

void Menu()
{
    Message("\n 1 - Add, using two Numbers");
    Message(" 2 - Add, using more than two Numbers");
    Message(" 3 - Subtract, using two Numbers");
    Message(" 4 - Subtract, using more than two Numbers");
    Message(" 5 - Multiply Numbers");
    Message(" 6 - Divide Numbers");
    Message(" 7 - Close Calculator");
}

void Message(string prompt, bool wholeLine = true)
{
        if (wholeLine)
            Console.WriteLine(prompt);
        else
            Console.Write(prompt);
}

void init()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
}