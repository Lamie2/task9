using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task1


            //Console.WriteLine("axtardiginiz deyeri daxil edin");
            //string valstr = Console.ReadLine();
            //int val = Convert.ToInt32(valstr);
            //int wantedIndex = FindLetterIndex(val, i);
            #endregion


            #region task2

            
            //int number = 26;
            //int SqrtRt = FindSqrt(number);
            //Console.WriteLine(SqrtRt);
            #endregion

            #region task3  

            //int n = 535;                                     //OKAY
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
            //int PositiveNums = MakePositive(NumArray);
            //Console.WriteLine($"positive array: {PositiveNums}");

            #endregion


        }



        #region task1 method


        //static int FindLetterIndex(int[] word, int letter)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == letter) 
        //        return 2;

        //    else
        //    {
        //        return -1;
        //    }

        //}
        #endregion


        #region task2 method    

        static int FindSqrt(int num)        //OKAY
        {
            int root = 0;
          if (num > 0)
          {
                for (int i = 0; i * i <= num; i++)
            {
                root = i;
            }
          }
           
               return root;
        }
        #endregion


        #region task3 method

        //static int FindSumOfNumber(int number)
        //{

        //    int s = 0;
        //    int N = number;
        //    while (N>0)
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
        //            return arr[i];
        //        }

        //    }
        //    return 1;

        //}
        #endregion


        #region task5 method

        //static int MakePositive(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i]<0)
        //        {
        //            numbers[i] = -(numbers[i]);
        //            return numbers[i];
        //        }
        //        else
        //        {
        //            return -1; //bilmedim ne yazim eks halda
        //        }
        //    }

        //}
        #endregion



    }


}

