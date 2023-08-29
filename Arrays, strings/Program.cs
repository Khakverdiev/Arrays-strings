// Task 1
//int rows = 3;
//int columns = 4;

//double[] a = new double[5];
//double[,] b = new double[rows, columns];

//double ElementA = a[0];
//double ElementB = b[0, 0];
//Random rand = new Random();

//Console.WriteLine("Filling array A");

//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write($"Enter {i} element of array A: ");
//    a[i] = Convert.ToDouble(Console.ReadLine());
//}

//Console.Write("Array A = [ ");
//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write($"{a[i]}  ");
//}
//Console.Write("] ");

//Console.WriteLine();

//for (int i = 0;i < rows; i++)
//{
//    for (int j = 0; j < columns; ++j)
//    {
//        // Round мне нужен для того чтобы округлить сорри если нельзя было
//        b[i, j] = Math.Round(rand.NextDouble(), 1) + rand.Next(100);
//    }
//}

//Console.WriteLine();
//Console.WriteLine("Array B: ");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; ++j)
//    {
//        Console.Write($"{b[i, j]}" + '\t');
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//for (int i = 1; i < a.Length; i++)
//{
//    if (a[i] > ElementA)
//    {
//        ElementA = a[i];
//    }
//}
//Console.WriteLine($"Max element A - {ElementA}");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; ++j)
//    {
//        if (b[i, j] > ElementB) 
//        {
//            ElementB = b[i, j];
//        }
//    }
//}
//Console.WriteLine($"Max element B - {ElementB}");

//if (ElementA == ElementB)
//{
//    Console.WriteLine($"Total maximum element - {ElementA}");
//}
//else
//{
//    Console.WriteLine("No Total Maximum Element");
//}

//for (int i = 0; i < a.Length; i++)
//{
//    if (ElementA > a[i])
//    {
//        ElementA= a[i];
//    }
//}
//Console.WriteLine($"Min Element A - {ElementA}");

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; ++j)
//    {
//        if (ElementB > b[i, j])
//        {
//            ElementB = b[i, j];
//        }
//    }
//}

//Console.WriteLine($"Min Element B - {ElementB}");

//double multiplicationA = 1;
//double multiplicationB = 1;

//for (int i = 0; i < a.Length; i++)
//{
//    multiplicationA *= a[i];
//}
//Console.WriteLine($"Multiplication A = {multiplicationA} ");

//for (int i = 0; i < rows; ++i)
//{
//    for(int j = 0; j < columns; ++j)
//    {
//        multiplicationB *= b[i, j];
//    }
//}
//Console.WriteLine($"Multiplication B = {multiplicationB} ");
//double multiplication3 = multiplicationA * multiplicationB;
//Console.WriteLine($"General multiplication - {multiplication3}");

//double sumEvenA = 0;
//double sumEvenB = 0;

//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] % 2 == 0)
//    {
//        sumEvenA += a[i];
//    }
//}

//Console.WriteLine($"Sum A - {sumEvenA}");

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        if (b[i, j] % 2.0 != 0)
//        {
//            sumEvenB += b[i, j];
//        }
//    }
//}
//Console.WriteLine($"Sum B - {sumEvenB}");

// Task 2
//int rows = 5;
//int cols = 5;
//int[,] arr = new int[rows, cols];
//int sumArr = 0;

//int max = arr[0, 0]; 
//int min = arr[0, 0];

//int indexMinX = 0;
//int indexMinY = 0;
//int indexMaxX = 0; 
//int indexMaxY = 0;

//bool count = false;
//Random rand = new Random();
//Console.WriteLine("Array B");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        arr[i, j] = rand.Next(-100, 100);
//        if (max < arr[i, j])
//        {
//            max = arr[i, j];
//            indexMinX = i;
//            indexMinY = j;
//        }
//        if (min > arr[i, j])
//        {
//            min = arr[i, j];
//            indexMaxX = i;
//            indexMaxY = j;
//        }
//        Console.Write($"{arr[i, j]}\t");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        if ((i == indexMinX && j == indexMinY) || (i == indexMaxX && j == indexMaxY))
//        {
//            if (count)
//            {
//                count = false;
//                continue;
//            }
//            else
//            {
//                count = true;
//                continue;
//            }
//        }
//        if (count)
//        {
//            sumArr += arr[i, j];
//        }
//    }
//}

//Console.WriteLine();

//Console.WriteLine($"Max element - {max}");
//Console.WriteLine($"Min element = {min}");
//Console.WriteLine($"Summary array created between minimum and maximum elements = {sumArr}");

// Task 3
//char[] alphabetArr = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 
//    'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 
//    'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
//string str = Console.ReadLine(); 

//// Я скопировал экземпляр в массив знаков юникода сорри если нельзя было...
//char[] strArr = str.ToCharArray();
//char[] arr1 = strArr; 
//char[] arr2 = strArr; 

//for (int i = 0; i < strArr.Length; i++)
//{
//    var ch = strArr[i]; 
//    for (int j = 0; j < alphabetArr.Length; j++) 
//    {                                            
//        if (ch == alphabetArr[j]) 
//        {                         
//            int num = j + 3; 
//            if (num > 33)
//            {
//                num %= 33;
//            }

//            arr1[i] = alphabetArr[num]; 
//        }
//        if (ch == ' ') 
//        {
//            arr1[i] = ' ';
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine("I encrypt:");
//for(int i = 0; i < arr1.Length; i++)
//{
//    Console.Write(arr1[i]);
//}

//for (int i = 0; i < strArr.Length; i++)
//{
//    var chr = strArr[i]; 
//    for (int j = 0; j < alphabetArr.Length; j++) 
//    {                                            
//        if (chr == alphabetArr[j]) 
//        {                         
//            int num2 = j - 3; 
//            if (num2 < 0)
//            {
//                num2 += 33;
//            }

//            arr2[i] = alphabetArr[num2]; 
//        }
//        if (chr == ' ')
//        {
//            arr2[i] = ' ';
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Decipher:");
//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.Write(arr2[i]);
//}
//Console.WriteLine();

// Task 4
//int rows = 3;
//int cols = 3;
//int[,] matrix = new int[rows, cols];
//int[,] matrix2 = new int[rows, cols];
//Random rand = new Random();

//for (int i = 0;i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		matrix[i, j] = rand.Next(100);
//		matrix2[i, j] = rand.Next(100);
//	}
//}

//Console.WriteLine("Matrix: ");
//for (int i = 0; i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		Console.Write($"{matrix[i,j]}\t");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine("Matrix2: ");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write($"{matrix2[i, j]}\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine("Enter a number to multiply the matrix: ");
//int digit = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < rows; ++i)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		matrix[i, j] *= digit;
//	}
//}

//for (int i = 0; i < rows; ++i)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        matrix2[i, j] *= digit;
//    }
//}

//int sum = 0;

//for (int i = 0; i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		sum = matrix[i, j] + matrix2[i, j];
//	}
//}
//Console.WriteLine();

//int multiplication = 1;

//for (int i = 0; i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		multiplication = matrix[i, j] * matrix2[i, j];
//	}
//}

//Console.WriteLine("Matrix1: ");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write($"{matrix[i, j]}\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine("Matrix2: ");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write($"{matrix2[i, j]}\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine($"Sum - {sum}");
//Console.WriteLine();
//Console.WriteLine($"Multiplication - {multiplication}");

// Task 5
//Console.WriteLine("Enter an arithmetic expression:");
//string str = Console.ReadLine();

//int num1 = 0;
//int num2 = 0;
//int result = 0;
//char op = ' ';
//int startIndex = 0;

//// Char.IsDigit нужен для того чтобы исправить IndexOutOfRangeException единственное что смог найти
//for (; startIndex < str.Length && Char.IsDigit(str[startIndex]);)
//{
//    num1 = num1 * 10 + (str[startIndex] - 48);
//    startIndex++;
//}

//op = str[startIndex];

//for (int i = startIndex; i < str.Length; i++)
//{
//    num2 = num2 * 10 + (str[i] - 48);
//}

//if (op == '+')
//{
//    result = num1 + num2;
//}
//if (op == '-')
//{
//    result = num1 - num2;
//}
//Console.WriteLine($"Result: {result}");

// Task 6
//string text = "today is a good day for walking. i will try to walk near the sea";
//string[] text2 = text.Split(new char[] { '.' });
//string result = "";

//foreach (string txt in text2)
//{
//    // метод Trim просто обрезает начальные и конечные пробелы и возвращает обрезанную строку
//    string trimmedText = txt.Trim();
//    char[] txtToChars = trimmedText.ToCharArray();

//    txtToChars[0] = char.ToUpper(txtToChars[0]);

//    string capitalizedText = new string(txtToChars);

//    result += capitalizedText + ".";
//}
//Console.WriteLine(result);

// Task 7
//string[] prohibitions = new string[] { "die" };

//string text = "To be, or not to be, that is the question, " +
//    "Whether 'tis nobler in the mind to suffer" +
//    "The slings and arrows of outrageous fortune," +
//    "Or to take arms against a sea of troubles," +
//    "And by opposing end them? To die: to sleep;" +
//    "No more; and by a sleep to say we end" +
//    "The heart-ache and the thousand natural shocks" +
//    "That flesh is heir to, 'tis a consummationDevoutly to be wish'd. To die, to sleep";

//string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' });
//string result = "";
//int[] replace = new int[prohibitions.Length];

//foreach (string word in words)
//{
//    bool obstruction = false;
//    for (int i = 0; i < prohibitions.Length; i++)
//    {
//        if (word == prohibitions[i])
//        {
//            obstruction = true;
//            replace[i]++;
//        }
//    }
//    if (obstruction == true)
//    {
//        for (int i = 0; i < 3; ++i)
//        {
//            result += "*";
//        }

//        result += " ";
//    }
//    else
//    {
//        result += word + " ";
//    }
//}
//Console.WriteLine(result);
//Console.WriteLine("Statistics: ");
//for (int i = 0; i < prohibitions.Length; i++)
//{
//    Console.WriteLine(prohibitions[i] + ": " + replace[i] + " times");
//}