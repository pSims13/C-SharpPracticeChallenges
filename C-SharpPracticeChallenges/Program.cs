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
        
         //Password Checker
        
         Console.WriteLine("Please enter your password");
        
         string userPassword = Console.ReadLine();
        
         Console.WriteLine("Please re-enter your password");
        
         if (Console.ReadLine() != userPassword)
         {
             Console.WriteLine("Password incorrect");
         }
         else
         {
             Console.WriteLine("Password Correct");
         }
        
         //Login System
        
         Console.WriteLine("Please choose a username:");
         string correctUsername = Console.ReadLine();
        
         Console.WriteLine("Please choose a password:");
         String correctUserPassword = Console.ReadLine();
        
         Console.WriteLine("Username and password set.");
        
         Console.WriteLine("To login please enter your username:");
         string userInputUsername = Console.ReadLine();
        
         Console.WriteLine("Please enter your password:");
         string userInputPassword = Console.ReadLine();
        
         if (userInputUsername == correctUsername && userInputPassword == correctUserPassword)
         {
             Console.WriteLine("Login successful");
         }
         else
         {
             Console.WriteLine("Invalid username or password");
         }
        
         //Leap Year Checker
        
         Console.WriteLine("Enter a year to check if it is a leap year");
        
         int userSelectYear = int.Parse(Console.ReadLine());
        
         if (userSelectYear % 4 == 0 || userSelectYear % 400 == 0)
         {
             Console.WriteLine("THe year you entered is a leap year");
         }
         else
         {
             Console.WriteLine("The year you entered is not a leap year");
         }
        
         //Switch Statements
        
         Console.WriteLine("Type a number 1-7");
         int dayNumber = int.Parse(Console.ReadLine());
        
         string dayName;
        
         switch (dayNumber)
         {
             case 1:
                 dayName = "Sunday";
                 break;
             case 2:
                 dayName = "Monday";
                 break;
             case 3:
                 dayName = "Tuesday";
                 break;
             case 4:
                 dayName = "Wednesday";
                 break;
             case 5:
                 dayName = "Thursday";
                 break;
             case 6:
                 dayName = "Friday";
                 break;
             case 7:
                 dayName = "Saturday";
                 break;
             default:
                 dayName = "Invalid day number";
                 break;
                 
         }
        
         Console.WriteLine(dayNumber);
        
         //Simple Calculator
        
         Console.Write("Enter a whole number: ");
         int numOne = int.Parse(Console.ReadLine());
        
         Console.WriteLine("Enter an operator ( + , - , * , / )");
         string userInputOp = Console.ReadLine();
        
         Console.WriteLine(("Enter a second whole number: "));
         int numTwo = int.Parse(Console.ReadLine());
        
         Console.WriteLine("Press enter to calculate numbers");
        
         Console.ReadLine();
        
         switch (userInputOperator)
         {
             case "+":
                 Console.WriteLine(numOne + numTwo);
                 break;
             case "-":
                 Console.WriteLine(numOne - numTwo);
                 break;
             case "*":
                 Console.WriteLine(numOne * numTwo);
                 break;
             case "/":
                 Console.WriteLine(numOne / numTwo);
                 if (numTwo == 0)
                 {
                     Console.WriteLine("Cannot divide by zero");
                 }
        
                 break;
             default:
                 Console.WriteLine("Invalid Operator");
                 break;
         }

        Weather Report

         Console.WriteLine("Of the three, which type of weather do you prefer? Sunny, Rainy or Snowy");
         string inputWeather = Console.ReadLine();
        
         string lowerInputWeather = inputWeather.ToLower();
        
         string preferredWeatherResponse;
        
         switch (lowerInputWeather)
         {
             case "sunny":
                 preferredWeatherResponse = "Sunny weather is great!";
                 break;
             case "rainy":
                 preferredWeatherResponse = "Better grab an umbrella";
                 break;
             case "snowy":
                 preferredWeatherResponse = "You must be an eskimo";
                 break;
             default:
                 preferredWeatherResponse = "That was not a valid choice";
                 break;
         }
        
         Console.WriteLine(preferredWeatherResponse);
        
         //Traffic Light Simulation
        
         Console.WriteLine("Enter a traffic light color. You can choose Red, Yellow, or Green");
        
         string inputTrafficLight = Console.ReadLine();
        
         string lowerTrafficLight = inputTrafficLight.ToLower();
        
         string trafficLightResponse;
        
         switch (lowerTrafficLight)
         {
             case "red":
                 trafficLightResponse = "RED LIGHT STOP!!!";
                 break;
             case "yellow":
                 trafficLightResponse = "Yellow light. Slooow down.";
                 break;
             case "green":
                 trafficLightResponse = "Green light. You can keep moving";
                 break;
             default:
                 trafficLightResponse = "That was not a valid choice";
                 break;
         }
             
         Console.WriteLine(trafficLightResponse);
        
         //For Loops
        
         //Print 1-10
        
         Console.WriteLine("List 1-10");
        
         for (double i = 0; i <= 10; i++)
         {
             Console.WriteLine(i);
         }

        Multiplication Table

        Console.WriteLine("Multiplication table 1-10");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                // if (j == 5)
                // {
                //     continue;
                // }
                Console.Write($"{i * j}\t");
            }

            Console.WriteLine();
        }
    }
}