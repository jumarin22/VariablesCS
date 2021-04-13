using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice Creating Variables.

            // Create a variable that stores the numberOfCupsOfCoffee that you drink every day.
            var numberOfCupsOfCoffee = 0.5;

            // Create a variable called fullName and set it equal to your full name.
            var fullName = "Justin Marin";

            // Create a variable called today and set it equal to today's date.
            var today = "Tuesday, April 13, 2021";

            // Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, 
            // to output all three on one line.
            Console.WriteLine($"{numberOfCupsOfCoffee} cups of coffee were consumed by {fullName} on this glorious day of {today}");

            // Practice Getting Input From the User.

            // Ask the user for their name and store it in a variable named userName.
            Console.WriteLine("Hey there, what's your name? ");
            var userName = Console.ReadLine();

            // Print out a greeting to the user, using their name.
            Console.WriteLine($"Well, it's certainly nice to meet you, {userName}!");

            // Practice Getting Different Types of Input From the User.
            // Ask the user to input two numbers.
            // Get the numbers as strings using Console.ReadLine, 
            // store them in variables named firstNumberAsString and secondNumberAsString.
            Console.Write($"So, {userName}, tell me: What's your favorite number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write($"{firstNumberAsString}? What a great number! Name a different number: ");
            var secondNumberAsString = Console.ReadLine();
            Console.WriteLine($"{secondNumberAsString}? Alright! let's move on.");

            // Converting String Input Into Numbers.

            // Convert each string above to a double using double.Parse. 
            // Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            // Doing Math.

            // Add the operand variables from above and save the results in a variable named sum.
            var sum = firstOperand + secondOperand;

            // Subtract the secondOperand variable from the firstOperand variable 
            // and save the results in a variable named difference.
            var difference = secondOperand - firstOperand;

            // Multiply the operand variables and save the results in a variable named product.
            var product = firstOperand * secondOperand;

            // Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstOperand / secondOperand;

            // Find the remainder when one operand is divided by the other and save the results in a variable named remainder. 
            var remainder = firstOperand % secondOperand;

            // Use Console.WriteLine to present the user, in a meaningful way, each of the values for 
            // the sum, difference, quotient, product, and remainder variables. 
            Console.WriteLine("Here's the skinny on those numbers you gave me...");
            Console.WriteLine($"When you add {firstOperand} and {secondOperand}, you get {sum}");
            Console.WriteLine($"When you subtract {firstOperand} from {secondOperand}, you get {difference}");
            Console.WriteLine($"When you multiply {firstOperand} by {secondOperand}, you get {product}");
            Console.WriteLine($"When you divide {firstOperand} by {secondOperand}, you get {quotient}");
            Console.WriteLine($"The remainder of {firstOperand} and {secondOperand} is {remainder}");

        }
    }
}
