namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sharp as Tramontina! \n\n");

            // Console.WriteLine("Hello World! C#");
            // Console.WriteLine(5 + 5);

            // int varPrinter = 15;
            // Console.WriteLine(varPrinter);

            // string varPrinter = "String type print";
            // Console.WriteLine(varPrinter);

            // const string varPrinter = "Testing a constant";
            // Console.WriteLine(varPrinter);

            // string varPrinter = "Your number is: ";
            // int varNumber = 5;
            // Console.WriteLine(varPrinter + varNumber);
            // Console.WriteLine("Your number is: " + varNumber);

            // int x = 10;
            // int y = 5;
            // Console.WriteLine(x + y);

            // int x = 5, y = 10;
            // Console.WriteLine(x + y);

            // bool varPrinter = true;
            // Console.WriteLine(varPrinter);

            // double myDouble = 5.5;
            // int myInt = (int)myDouble;
            // Console.WriteLine($"The data type of myInt is: {myInt.GetType().Name}");
            // Console.WriteLine($"The Full data type of myInt is: {myInt.GetType().FullName}");

            // double myDouble = 5.5;
            // int myInt = (int)myDouble;
            // Console.WriteLine($"The data type of myInt is: {myInt.GetType().Name}");
            // Console.WriteLine($"The Full data type of myInt is: {myInt.GetType().FullName}");
            // Console.WriteLine($"Converting the integer value to string: {Convert.ToString(myInt).GetType().Name}");

            // Console.WriteLine($"Place a string input: ");
            // string myInput = Console.ReadLine();
            // Console.WriteLine($"You entered: {myInput}");

            // OPERATORS
            /*
            * == Comparison
            * != different
            * && OR
            * || xOR
            * ! NOT
            * >= Greater equals
            * <= Lesser equals
            * + SUM
            * - MINUS
            * 8 MULTIPLY
            * '/' DEVIDE
            * ++ INCREMENTS 1
            * -- DECREMENTS 1
            */

            // Grabs the Minimum value between two numbers
		    // double result = Math.Min(5, 10);
		    // Console.WriteLine(result);

            // Grabs the Maximum value between two numbers
		    // double result = Math.Max(5, 10);
		    // Console.WriteLine(result);

            // Grabs the square root of a value
		    // double result = Math.Sqrt(10);
		    // Console.WriteLine(result);


            // Grabs the round result of a value
		    // double result = Math.Round(2.6);
		    // Console.WriteLine(result);

            // Grabs the absolute number of a value
		    // double result = Math.Abs(-4.7);
		    // Console.WriteLine(result);

            // Convert to uppercase
			// string result = "Uppercut!";
		    // Console.WriteLine(result.ToUpper());

            // Lenght of a value
	        // string result = "Uppercut!";
		    // Console.WriteLine(result.Length);

            // Convert to lowercase
            // string result = "SHRINK!";
		    // Console.WriteLine(result.ToLower());

            // Concatenate strings
	        // string firstName = "Sometimes the 1st, ";
	        // string secondName = "Others the last, \n";
	        // string thirdName = "But you won't get me out of the Race!";
		    // Console.WriteLine(string.Concat(firstName, secondName, thirdName));

            // Concatenate strings
			// string firstName = "Sometimes the 1st, ";
			// string secondName = "Others the last, \n";
			// string thirdName = "But you won't get me out of the Race!";
		    // Console.WriteLine(string.Concat(firstName, secondName, thirdName));

			// Slicing
			// string firstName = "Reach the 1st";
			// Console.WriteLine(firstName[0]);

			// Get index
			// string firstName = "Indexing...";
			// Console.WriteLine(firstName.IndexOf("x"));

			// usage of substring to grab the word that belongs to a specific character and ahead of it
			// initially grabbed by index
			string name = "Grab the Third Word";
			int charPos = name.IndexOf("T");
			string thirdWord = name.Substring(charPos);
			Console.WriteLine(thirdWord);


        }
    }
}