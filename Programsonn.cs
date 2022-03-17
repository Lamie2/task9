using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task1

            //Console.WriteLine("sozu daxil edin");
            //string word = Console.ReadLine();
            //Console.WriteLine("axtardiginiz xarakteri daxil edin");
            //string searchLetterString = Console.ReadLine();
            //char searchLetter = searchLetterString[0];
            //int wantedIndex = FindLetterIndex(word, searchLetter);
            //Console.WriteLine("Cavab: " + wantedIndex);

            #endregion


            #region task2


            //int number = 26;
            //int SqrtRt = FindSqrt(number);
            //Console.WriteLine(SqrtRt);
            #endregion

            #region task3  

            //int n = 535;
            //int sum = FindSumOfNumber(n);
            //Console.WriteLine(sum);
            #endregion

            #region task4


            //int[] arr = { 5, 10, 66, 77 };
            //int MaxNum = FindMaxValue(arr);
            //Console.WriteLine($"maxNum: {MaxNum}");
            #endregion

            #region task 5

            //int[] NumArray = { 7, -4, -8, 15 };
            //int[] PositiveNums = MakePositive(NumArray);
            //for (int i = 0; i < PositiveNums.Length; i++)
            //{
            //    Console.WriteLine($"positive array: {PositiveNums[i]}");
            //}


            #endregion


        }



        #region task1 method 


        //static int FindLetterIndex(string word, char letter)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == letter)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        #endregion


        #region task2 method    

        //static int FindSqrt(int num)        
        //{
        //    int root = 0;
        //    if (num > 0)
        //    {
        //        for (int i = 0; i * i <= num; i++)
        //        {
        //            root = i;
        //        }
        //    }

        //    return root;
        //}
        #endregion


        #region task3 method

        //static int FindSumOfNumber(int number)
        //{

        //    int s = 0;
        //    int N = number;
        //    while (N > 0)
        //    {
        //        s = s + (N % 10);
        //        N = N / 10;
        //    }
        //    return s;
        //}
        #endregion


        #region task4 method


        //static int FindMaxValue(int[] arr)
        //{
        //    int max = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    return max;
        //}
        #endregion


        #region task5 method

        //static int[] MakePositive(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < 0)
        //        {
        //            numbers[i] = -(numbers[i]);
        //        }

        //    }
        //    return numbers; 

        //}

        #endregion



    }


}

