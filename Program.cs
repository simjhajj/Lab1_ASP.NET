namespace MathMethod

{
    // Name: Simrandeep Kaur
    // student ID: 200554998
    // Lab 1   

    // class name
    internal class Program
    {
        // main method
        public static void Main(string[] args)
        {
            // ask user to enter a value from 1 to 10
            Console.WriteLine("Please input an integer from 0 to 10");

            // conditions for user value
            // if user input is between 0 and 10 then try to parse the value given by user into an integer
            // the out keyword is used to declare userValue as an output parameter
            if (int.TryParse(Console.ReadLine(), out int userValue) && userValue >= 0 && userValue <= 10)
            {
                // display userValue and factorial

                // result variable will store the factorial of the integer value provided by user
                // getFactorial(userValue) is the method used to calculate factorial
                int result = GetFactorial(userValue);

                // representing the factorial of given userValue
                Console.WriteLine($"Factorial of {userValue} is {result}");
            }
           
            // display error message id integer is not between 0 and 10
            else
            {
                Console.WriteLine("Invalid Input. Please enter an integer between 0 and 10");
            }

            // static method to GetFactorial
            // created static method as it is easy to use in main method
            static int GetFactorial(int value)
            {

                // if value is between 0 and 1 return factorial 1
                if (value == 0 || value == 1)
                {
                    return 1;
                }

                else {
                    // initialized the result variable to store the factorial value
                    int result = 1;

                    // a for loop to calculate the factorial
                    for (int i = 2; i <= value; i++)
                    {
                        // multiply the current result by the current value of 'i'
                        result *= i; 
                    }

                    // Return the calculated factorial
                    return result;
                }
            }
        } // main method
    } // class
} // namespace
