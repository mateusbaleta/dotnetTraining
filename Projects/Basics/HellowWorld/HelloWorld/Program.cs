namespace HelloWorld;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("\nSharp as Tramontina! \n");

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
		// string name = "Grab the Third Word";
		// int charPos = name.IndexOf("T");
		// string thirdWord = name.Substring(charPos);
		// Console.WriteLine(thirdWord);

		// inline conditions with ternary operator "?" which is replaced by the
		// condition itself and returning/storing the value that fulfills the codition
		// to the function/variable
		// int time = 20;
		// string response = (time < 20) ? "Still early!" : "It's really late!";
		// Console.WriteLine(response);

		// SWITCH CASE + WHILE LOOP USAGE
		// int destiny;
		// while (true)
		// {
		// 	Console.WriteLine("Choose your destiny: \n");
		// 	Console.WriteLine("1 = Scorpion");
		// 	Console.WriteLine("2 = Subzero");
		// 	Console.WriteLine("3 = Liu Kang");
		// 	destiny = Convert.ToInt32(Console.ReadLine());
		//
		// 	switch(destiny)
		// 	{
		// 		case 1:
		// 			Console.WriteLine("\nGet over here!");
		// 			break;
		//
		// 		case 2:
		// 			Console.WriteLine("\nFreeze!");
		// 			break;
		// 		case 3:
		// 			Console.WriteLine("\nGet that bike!");
		// 			break;
		// 	}

		// SWITCH CASE + WHILE LOOP USAGE
		// int destiny;
		// while (true)
		// {
		// 	Console.WriteLine("Choose your destiny: \n");
		// 	Console.WriteLine("1 = Scorpion");
		// 	Console.WriteLine("2 = Subzero");
		// 	Console.WriteLine("3 = Liu Kang");
		// 	destiny = Convert.ToInt32(Console.ReadLine());
		//
		// 	switch(destiny)
		// 	{
		// 		case 1:
		// 			Console.WriteLine("\nGet over here!");
		// 			break;
		//
		// 		case 2:
		// 			Console.WriteLine("\nFreeze!");
		// 			break;
		// 		case 3:
		// 			Console.WriteLine("\nGet that bike!");
		// 			break;
		// 	}

		// WHILE LOOP usage
		// int i = 0;
		// while (i < 11)
		// {
		// 	Console.WriteLine(i);
		// 	i++;
		// }

		// WHILE LOOP usage
		// int i = 0;
		// do
		// {
		// 	Console.WriteLine(i);
		// 	i++;
		// } while (i < 11);


		// FOR LOOP usage
		// for (int i = 0; i < 5; i++)
		// {
		// 	Console.WriteLine("Yes");
		// }

		// USING ARRAYS
		// string[] boogie = { "Pop", "Lock", "Groovy", "Boogie" };
		// Console.WriteLine(boogie[0]);

		// USING ARRAYS
		// string[] boogie = {"Popping", "Locking", "Breaking", "Hardstyle"};
		// while (true)
		// {
		// 	Console.WriteLine("Pick boogie your style:");
		// 	Console.WriteLine("1 - Popping");
		// 	Console.WriteLine("2 - Locking");
		// 	Console.WriteLine("3 - Breaking");
		// 	Console.WriteLine("4 - Hardstyle");
		// 	int moves = Convert.ToInt32(Console.ReadLine());
		//
		// 	switch (moves)
		// 	{
		// 		case 1:
		// 			Console.WriteLine(boogie[0]);
		// 			break;
		// 		case 2:
		// 			Console.WriteLine(boogie[1]);
		// 			break;
		// 		case 3:
		// 			Console.WriteLine(boogie[2]);
		// 			break;
		// 		case 4:
		// 			Console.WriteLine(boogie[3]);
		// 			break;
		// 	}
		// }

		// Give array a lenght
		// string[] cars = new string[4] { "Wheels1", "Wheels2", "Wheels3", "Wheels4" };
		// Console.WriteLine(cars[3]);

		// Use of FOREACH
		// string[] cars = { "Wheels1", "Wheels2", "Wheels3", "Wheels4" };
		// foreach (string i in cars)
		// {
		// 	Console.WriteLine(i);
		// }

		// Iterating over an ARRAY
		// string[] cars = { "Wheels1", "Wheels2", "Wheels3", "Wheels4" };
		// for (int i = 0; i < cars.Length; i++)
		// {
		// 	Console.WriteLine(cars[i]);
		// }

		// Sorting ARRAYS
		// string[] cars = { "Wheels1", "Wheels2", "Wheels3", "Wheels4" };
		// Array.Sort(cars);
		// for (int i = 0; i < cars.Length; i++)
		// {
		// 	Console.WriteLine(cars[i]);
		// }

		// Multi dimensional ARRAYS
		// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
		// Console.WriteLine(numbers[1, 2]);

		// Multi dimensional ARRAYS
		int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
		Console.WriteLine(numbers.GetLength(0));

	}

}