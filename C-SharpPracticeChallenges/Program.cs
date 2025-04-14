namespace C_SharpPracticeChallenges;

class Program
{
    static void Main(string[] args)
    {
        //Variables

        //Store Your Info

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();

        Console.WriteLine("What city do you live in?");
        string city = Console.ReadLine();

        //Swap Two Numbers

        Console.WriteLine("User number 1 how old are you?");
        string user1Age = Console.ReadLine();

        Console.WriteLine("User number 2 how old are you?");
        string user2Age = Console.ReadLine();

        Console.WriteLine($"User number 1 is {user1Age} years old and User number 2 is {user2Age} years old");

        (user1Age, user2Age) = (user2Age, user1Age);

        Console.WriteLine(
            $"If i swapped User number 1 and User number 2's age then user Number 1 would be {user1Age} and User number 2 would be {user2Age}.");

        //Temperature Tracker

        Console.WriteLine("What is your temp in celsius?");

        string userInputCelsius = Console.ReadLine();

        double celsius = double.Parse(userInputCelsius);

        double celsiusToFahrenheit = celsius * 1.8 + 32;

        Console.WriteLine($"It's {celsiusToFahrenheit} fahrenheit");

        //Area of a Circle

        Console.WriteLine("What is the radius of your circle?");

        string userInputRadius = Console.ReadLine();

        double radius = double.Parse(userInputRadius);

        double areaOfCircle = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"The area of the circle is {areaOfCircle}");

        //Favorite Things

        Console.WriteLine("What is your favorite  food?");
        string userInputFood = Console.ReadLine();

        Console.WriteLine("What is your favorite movie?");
        string userInputMovie = Console.ReadLine();

        Console.WriteLine("What is your favorite color?");
        string userInputColor = Console.ReadLine();


        Console.WriteLine(
            $"My favorite color is {userInputColor} and i like to eat {userInputFood} while watching {userInputMovie}.");


        //Operators

        //Calculator

        Console.Write("Enter a whole number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an operator ( + , - , * , / )");
        string userInputOperator = Console.ReadLine();

        Console.WriteLine(("Enter a second whole number: "));
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Press enter to calculate numbers");

        Console.ReadLine();

        switch (userInputOperator)
        {
            case "+":
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case "-":
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case "*":
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case "/":
                Console.WriteLine(firstNumber / secondNumber);
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }

                break;
            default:
                Console.Write("Invalid Operator");
                break;
        }


        //Even or Odd

        Console.WriteLine("Enter a random whole number: ");

        string userInputRandomNum = Console.ReadLine();

        int randomNumber = int.Parse(userInputRandomNum);

        if (randomNumber % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }

        randomNumber++;

        Console.WriteLine($"Your random number plus 1 is {randomNumber}");

        randomNumber--;

        Console.WriteLine($"Your new number minus 1 is {randomNumber}");


        //Age Comparison

        Console.WriteLine("I am 30 years old. How old are you?");

        string userInputAge = Console.ReadLine();

        int userAge = int.Parse(userInputAge);

        if (userAge > 30)
        {
            Console.WriteLine("You are older than me!");
        }
        else if (userAge < 30)
        {
            Console.WriteLine("You are younger than me!");
        }
        else
        {
            Console.WriteLine("We are the same age.");
        }

        //Discount Calculator 

        Console.WriteLine("Choose a price you want to spend on a hat.");

        string userInputPrice = Console.ReadLine();

        decimal price = decimal.Parse(userInputPrice);

        decimal discount = .20m;

        decimal applyDiscount = price * discount;

        decimal finalPrice = price - applyDiscount;

        Console.WriteLine(
            $"If you have {userInputPrice} dollars to spend on a hat and I apply a 20% discount then you will save ${applyDiscount} bringing your total to ${finalPrice}.");

        //If Statements

        //Voting Eligibility 

        Console.WriteLine("Please enter your age:");
        int newUserAge = int.Parse(Console.ReadLine());

        if (userAge >= 18)
        {
            Console.WriteLine("You are old enough to vote!");
        }
        else
        {
            Console.WriteLine("You are too young to vote...");
        }

        //Number Comparison 

        Console.WriteLine("\nPlease Enter a whole number:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPlease enter another whole number");
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.Write("Your first number is higher than your second number.");
        }
        else if (firstNum < secondNum)
        {
            Console.WriteLine("Your first number is lower than your second number.");
        }
        else
        {
            Console.WriteLine("Your numbers are equal");
        }
    }
}