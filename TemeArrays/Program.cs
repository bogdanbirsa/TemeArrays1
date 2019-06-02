using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TemeArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //displayindex();
            //reverse();
            //nroccurence();
            //insert();
            //remove();
            //sumAll();
            //unique();
            //merge();
            //biggest();
            //smallest();
            //separateOddEven();
            //SortAsc();
            //SortDsc();
            //secondLargest();
            //secondSmallest();
            //matrix();
            //twoMatrix();


        }
        //1. Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.

        static void displayindex()
        {
            int[] array = new int[5];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //2. Write a method to reverse the order of the items in the array
        static void reverse()
        {
            int[] sir = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int a in sir)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(sir);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in sir)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }

        //3. Write a method to get the number of occurrences of a specified element in an array
        static void nroccurence()
        {
            Console.WriteLine("add the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Add element {i}");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            var count = 0;
            Console.WriteLine("Which number are you looking for...");
            int number = int.Parse(Console.ReadLine());

            foreach (var element in myArray)
            {
                if (element == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"{ number} found { count} Time");
        }


        //4. Write a method to insert a new item before the second element in an existing array
        static void insert()
        {
            string[] str1 = { "1", "2", "6" };
            List<String> firstlist = new List<String>(str1);
            Console.WriteLine("Elements in List: \n");
            foreach (string dis in firstlist)
            {
                Console.WriteLine(dis);
            }

            Console.WriteLine(" ");
            str1 = new string[] { "3", "4", "5" };
            Console.WriteLine("InsertRange(2, str1)\n");
            firstlist.InsertRange(2, str1);
            foreach (string res in firstlist)
            {
                Console.WriteLine(res);
            }
        }



        //5. Write a method to remove a specified item using the index from an array.
        static void remove()
        {
            ArrayList myList = new ArrayList(5);
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");


            Console.WriteLine("The elements in ArrayList initially are :");
            foreach (string str in myList)
                Console.WriteLine(str);

            myList.RemoveAt(2);
            Console.WriteLine("The elements in ArrayList are :");
            foreach (string str in myList)
                Console.WriteLine(str);
        }

        //6. Write a program to find the sum of all elements of the array
        static void sumAll()
        {
            int[] number = new int[] { 2, 5, 9, 11 };

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine(sum);
        }


        //7. Write a program to print all unique elements in an array.
        static void unique()
        {
            int[] arr = new int[100]; ;
            int i, j, k, size, isUnique;

            Console.WriteLine("Enter length of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < size; i++)
            {
                isUnique = 1;

                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        size--;
                        j--;
                        isUnique = 0;
                    }
                }

                if (isUnique != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

            Console.WriteLine("All unique elements in the array are: ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.ReadLine();
        }


        //8. Write a program to merge two arrays of same size sorted in ascending order.
        static void merge()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[200];
            int s1, s2, s3;
            int i, j, k;


            Console.Write("\n\nMerge two arrays of same size sorted in ascending order.\n");
            Console.Write("------------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the first array :");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the number of elements to be stored in the second array :");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s2);
            for (i = 0; i < s2; i++)
            {
                Console.Write("element - {0} : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            s3 = s1 + s2;


            for (i = 0; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            for (i = 0; i < s3; i++)
            {
                for (k = 0; k < s3 - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }

            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < s3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }


        //9. Write a program to find maximum and minimum element in an array.
        static void biggest()
        {
            int[] myArray = new int[] { 3, 7, 99, 43 };
            var max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"Maximum: {max}");
        }

        //smallest element in the array
        static void smallest()
        {
            int[] myArray = new int[] { 3, 7, 99, 43 };
            var max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i] < max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"Minimum: {max}");
        }


        //10. Write a programin to separate odd and even integers in separate arrays
        static void separateOddEven()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;


            Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
            Console.Write("------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }


        //11. Write a program to sort elements of array in ascending order.
        static void SortAsc()
        {
            int[] myArray = new int[] { 1, 2, 3, 4 };
            int temp;

            for (int i = 0; i < myArray.Length - 1; i++)

                for (int j = i + 1; j < myArray.Length; j++)

                    if (myArray[i] > myArray[j])
                    {

                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

            foreach (int elem in myArray)
            {
                Console.Write($"{elem}, ");
            }
        }


        //12. Write a program to sort elements of the array in descending order.
        static void SortDsc()
        {
            int[] myArray = new int[] { 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < myArray.Length - 1; i++)

                for (int j = i + 1; j < myArray.Length; j++)

                    if (myArray[i] < myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

            foreach (int elem in myArray)
            {
                Console.Write($"{elem}, ");
            }

        }


        //13. Write a program to find the second largest element in an array.
        static void secondLargest()
        {
            int[] myArray = new int[] { 3, 8, 99, 43 };
            var max = myArray[0];
            var secondMax = max;
            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
                Array.Reverse(myArray);
                if (max == secondMax)
                {
                    secondMax = myArray[i]--;
                }
            }
            Console.WriteLine($"Second largest is: {secondMax}");
        }


        //14. Write a program to find the second smallest element in an array.
        static void secondSmallest()
        {
            int[] myArray = new int[] { 3, 8, 99, 43 };
            var max = myArray[0];
            var secondMin = max;
            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i] < max)
                {
                    max = myArray[i];
                }
                if (max == secondMin)
                {
                    secondMin = myArray[i]--;

                }
            }
            Console.WriteLine($"Second smallest is: {secondMin}");
        }


        //TODO saturday
        //15. Write a program for a 2D array of size 3x3 and print the matrix.

        static void matrix()
        {
            int[,] myArray = new int[3, 3]; // 3 = number of rows; 3 = number of collums

            myArray[0, 0] = 1;
            myArray[0, 1] = 2;
            myArray[0, 2] = 3;

            myArray[1, 0] = 4;
            myArray[1, 1] = 5;
            myArray[1, 2] = 6;

            myArray[2, 0] = 7;
            myArray[2, 1] = 8;
            myArray[2, 2] = 9;

            //1,2,3
            //4,5,6
            //7,8,9
            int[,] myArray2 =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.WriteLine($"myArray[{row},{col}] = {myArray[row, col]}");
                }
            }
        }


        //16. Write a program in C# Sharp for addition of two Matrices of same size
        static void twoMatrix()
        {
            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[,] C = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
