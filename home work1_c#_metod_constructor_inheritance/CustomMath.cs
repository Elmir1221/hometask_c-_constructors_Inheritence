using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work1_c__metod_constructor_inheritance
{
    internal class CustomMath
    {
        //public int SumOfOdds(int[] array)
        //{
        //    int sum = 0;
        //    foreach (int element in array)
        //    {
        //        if (element % 2 != 0)
        //        {
        //            sum += element;
        //        }
        //    }
        //    return sum;
        //}

        //public string SingleAndDouble(int numb)
        //{
        //    if (numb % 2 == 0)
        //    {
        //        return "Cutdur";
        //    }
        //    else
        //    {
        //        return "Tekdir";
        //    }
        //}

        //public int SquareOfOdds(int[] array)
        //{
        //    int sum = 0;
        //    foreach (int elems in array)
        //    {
        //        if (elems % 2 == 0)
        //        {
        //            sum += elems;
        //        }
        //    }
        //    return sum * sum;
        //}

        //public int SumOfNumb(int n)
        //{
        //    int count = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        count += i;
        //    }
        //    return count;
        //}

      public int SumOfOdds(int[] array)
      {
         int sum = 0;

         foreach (var elems in array)
         {
            if (elems % 2 != 0)
            {
              sum += elems;
            }
         }
         return sum;
      }

      public string SingleAndDouble(int n) 
      {
            if (n % 2 == 0) 
            {
                return "cutdur";            
            }
            else 
            {
                return "tekdir";
            }
      }


      public int SquareOfOdds(int[] array) 
      {
        int sum = 0;

            foreach (var elems in array)
            {
                if (elems % 2 == 0) 
                {
                    sum += elems;
                }
                
            }
            return sum * sum;
      }
      
      public int SumOfnumb(int x) 
      {
         int Count = 0;

         for (int i = 1; i <= x; i++)
         {
             Count+=i;
         }
         return Count;
            
      }


    }
}
