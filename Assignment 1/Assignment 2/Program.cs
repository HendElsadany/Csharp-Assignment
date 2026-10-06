namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
               

                /* Q1
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 3 == 0 && number % 4 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                */


                /* Q2
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    Console.WriteLine("negative");
                else
                    Console.WriteLine("positive");
                */


                /* Q3
                Console.Write("Enter 3 integers: ");
                string[] parts = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                int a = Convert.ToInt32(parts[0]);
                int b = Convert.ToInt32(parts[1]);
                int c = Convert.ToInt32(parts[2]);

                int max = a;
                int min = a;

                if (b > max) max = b;
                if (c > max) max = c;
                if (b < min) min = b;
                if (c < min) min = c;

                Console.WriteLine("Max element = " + max);
                Console.WriteLine("Min element = " + min);
                */


                /* Q4
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
                */


                /* Q5
                Console.Write("Enter a character: ");
                char ch = Convert.ToChar(Console.ReadLine());
                char lower = char.ToLower(ch);

                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    Console.WriteLine("vowel");
                else
                    Console.WriteLine("Consonant");
                */


                /* Q6
                Console.Write("Enter an integer: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i);
                    if (i < n)
                        Console.Write(", ");
                }
                Console.WriteLine();
                */


                /* Q7
                Console.Write("Enter an integer: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(n * i + " ");
                }
                Console.WriteLine();
                */


                /* Q8
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i < n; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                */


                /* Q9
                Console.Write("Enter base and exponent: ");
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int baseNum = Convert.ToInt32(parts[0]);
                int exp = Convert.ToInt32(parts[1]);

                long result = 1;
                for (int i = 0; i < exp; i++)
                {
                    result = result * baseNum;
                }

                Console.WriteLine(result);
                */


                /* Q10
                Console.Write("Enter Marks of five subjects: ");
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int total = 0;
                for (int i = 0; i < 5; i++)
                {
                    total += Convert.ToInt32(parts[i]);
                }

                int average = total / 5;
                int percentage = total * 100 / 500;

                Console.WriteLine("Total marks = " + total);
                Console.WriteLine("Average Marks = " + average);
                Console.WriteLine("Percentage = " + percentage);
                */


                /* Q11
                Console.Write("Month Number: ");
                int month = Convert.ToInt32(Console.ReadLine());
                int days = 0;

                switch (month)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        days = 31;
                        break;
                    case 4: case 6: case 9: case 11:
                        days = 30;
                        break;
                    case 2:
                        days = 28;
                        break;
                    default:
                        Console.WriteLine("Invalid month number");
                        break;
                }

                if (days != 0)
                    Console.WriteLine("Days in Month: " + days);
                */


                /* Q12
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+  -  x  /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine("Result = " + (num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("Result = " + (num1 - num2));
                        break;
                    case 'x':
                    case 'X':
                        Console.WriteLine("Result = " + (num1 * num2));
                        break;
                    case '/':
                        if (num2 == 0)
                            Console.WriteLine("Cannot divide by zero");
                        else
                            Console.WriteLine("Result = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
                */


                /* Q13
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                string reversed = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversed += text[i];
                }

                Console.WriteLine(reversed);
                */


                /* Q14
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool isNegative = number < 0;
                if (isNegative)
                    number = -number;

                int reversed = 0;
                while (number > 0)
                {
                    reversed = reversed * 10 + number % 10;
                    number = number / 10;
                }

                if (isNegative)
                    reversed = -reversed;

                Console.WriteLine(reversed);
                */


                /* Q15
                Console.Write("Input starting number of range: ");
                int start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input ending number of range : ");
                int end = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The prime number between " + start + " and " + end + " are :");

                for (int i = start; i <= end; i++)
                {
                    if (i < 2)
                        continue;

                    bool isPrime = true;
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        Console.Write(i + " ");
                }
                Console.WriteLine();
                */


                /* Q16
                Console.Write("Enter a number to convert : ");
                int number = Convert.ToInt32(Console.ReadLine());
                int original = number;

                string binary = "";
                if (number == 0)
                    binary = "0";

                while (number > 0)
                {
                    binary = (number % 2) + binary;
                    number = number / 2;
                }

                Console.WriteLine("The Binary of " + original + " is " + binary + ".");
                */


                /* Q17
                Console.Write("Enter x1 y1: ");
                string[] p1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.Write("Enter x2 y2: ");
                string[] p2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.Write("Enter x3 y3: ");
                string[] p3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                double x1 = Convert.ToDouble(p1[0]);
                double y1 = Convert.ToDouble(p1[1]);
                double x2 = Convert.ToDouble(p2[0]);
                double y2 = Convert.ToDouble(p2[1]);
                double x3 = Convert.ToDouble(p3[0]);
                double y3 = Convert.ToDouble(p3[1]);

                double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

                if (area == 0)
                    Console.WriteLine("The points lie on a single straight line");
                else
                    Console.WriteLine("The points do NOT lie on a single straight line");
                */


                /* Q18
                Console.Write("Enter the time taken (in hours): ");
                double time = Convert.ToDouble(Console.ReadLine());

                if (time <= 3)
                    Console.WriteLine("Highly efficient");
                else if (time <= 4)
                    Console.WriteLine("Increase your speed");
                else if (time <= 5)
                    Console.WriteLine("You will be provided with training to enhance your speed");
                else
                    Console.WriteLine("You are required to leave the company");
                */


                /* Q19
                Console.Write("Enter n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                            Console.Write("1 ");
                        else
                            Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
                */


                /* Q20
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine("Sum of all elements = " + sum);
                */


                /* Q21
                Console.Write("Enter size of the arrays: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr1 = new int[size];
                int[] arr2 = new int[size];

                Console.WriteLine("Enter first array (ascending order):");
                for (int i = 0; i < size; i++)
                {
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter second array (ascending order):");
                for (int i = 0; i < size; i++)
                {
                    arr2[i] = Convert.ToInt32(Console.ReadLine());
                }

                int[] merged = new int[size * 2];
                int x = 0, y = 0, k = 0;

                while (x < size && y < size)
                {
                    if (arr1[x] <= arr2[y])
                        merged[k++] = arr1[x++];
                    else
                        merged[k++] = arr2[y++];
                }
                while (x < size)
                    merged[k++] = arr1[x++];
                while (y < size)
                    merged[k++] = arr2[y++];

                Console.WriteLine("Merged array:");
                for (int i = 0; i < merged.Length; i++)
                {
                    Console.Write(merged[i] + " ");
                }
                Console.WriteLine();
                */


                /* Q22
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                bool[] counted = new bool[size];

                for (int i = 0; i < size; i++)
                {
                    if (counted[i])
                        continue;

                    int count = 1;
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            counted[j] = true;
                        }
                    }

                    Console.WriteLine(arr[i] + " occurs " + count + " time(s)");
                }
                */


                /* Q23
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max = arr[0];
                int min = arr[0];

                for (int i = 1; i < size; i++)
                {
                    if (arr[i] > max) max = arr[i];
                    if (arr[i] < min) min = arr[i];
                }

                Console.WriteLine("Maximum element = " + max);
                Console.WriteLine("Minimum element = " + min);
                */


                /* Q24
                Console.Write("Enter array size (at least 2): ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int largest = int.MinValue;
                int second = int.MinValue;

                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > largest)
                    {
                        second = largest;
                        largest = arr[i];
                    }
                    else if (arr[i] > second && arr[i] != largest)
                    {
                        second = arr[i];
                    }
                }

                if (second == int.MinValue)
                    Console.WriteLine("There is no second largest element");
                else
                    Console.WriteLine("Second largest element = " + second);
                */


                /* Q25
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int longest = -1;

                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                         
                            int distance = j - i - 1;
                            if (distance > longest)
                                longest = distance;
                        }
                    }
                }

                if (longest == -1)
                    Console.WriteLine("There are no equal cells");
                else
                    Console.WriteLine("The longest distance = " + longest);
                */


                /* Q26
                Console.Write("Enter words: ");
                string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Array.Reverse(words);

                Console.WriteLine(string.Join(" ", words));
                */


                /* Q27
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                int[,] first = new int[rows, cols];
                int[,] second = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("Enter element [" + i + "," + j + "]: ");
                        first[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        second[i, j] = first[i, j];
                    }
                }

                Console.WriteLine("Second array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(second[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                */


                /* Q28
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Array in reverse order:");
                for (int i = size - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                */

            }
        }
    }
}
    }
}
