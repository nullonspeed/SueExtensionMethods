using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueExtensionMethods
{
    public static class MyExtentionMethods
    {
        public static int MyCount<T>(this List<T> ints)
        {
            int counts = 0;
            foreach (var i in ints)
            {
                counts++;
            }


            return counts;
        }

        public static int? MyMax(this List<int>? ints)
        {
            int? MaxVAlue = 0;
            foreach (var i in ints)
            {
                MaxVAlue = MaxVAlue < i ? i : MaxVAlue;
            }


            return MaxVAlue;
        }


        public static int? MyMin(this List<int>? ints)
        {
            int? MinVAlue = ints[0];
            foreach (var i in ints)
            {
                MinVAlue = MinVAlue > i ? i : MinVAlue;
            }


            return MinVAlue;
        }

        public static int? MySum(this List<int>? ints)
        {
            int? Sum = 0;
            foreach (var i in ints)
            {
                Sum += i;
            }


            return Sum;
        }
        public static int? MyAvg(this List<int>? ints)
        {
            int Sum = 0;
            int count = 0;
            foreach (var i in ints)
            {
                Sum += i;
                count++;
            }
            int AVG = Sum / count;


            return AVG;
        }
        public static List<int>? MyOrderByDescending(this List<int>? ints)
        {
            var intList = new List<int>();
           
            


            return intList;
        }


        public static List<T> MyWhere<T>(this List<T> inputList, Predicate<T> myPredicate)
        {

            var returnList = new List<T>();


            foreach (var item in inputList)
            {
                if (myPredicate(item))
                {
                   returnList.Add(item);
                }
            }

            return returnList;

        }
        public static List<T> MyTakeWhile<T>(this List<T> inputList, Predicate<T> myPredicate)
        {

            var returnList = new List<T>();


            for (int i = 0; i < inputList.Count && myPredicate(inputList[i]); i++)
            {
                returnList.Add(inputList[i]);
            }
            

            return returnList;

        }
        public static List<T> MySkipWhile<T>(this List<T> inputList, Predicate<T> myPredicate)
        {

            var returnList = new List<T>();
           int dummyCounter = 0;

            for (int i = 0; i < inputList.Count && myPredicate(inputList[i]); i++)
            {
                dummyCounter++;
            }
            for (int i = dummyCounter; i < inputList.Count ; i++)
            {
                returnList.Add(inputList[i]);
            }

            return returnList;

        }
        public static List<TRes> MySelect<T,TRes>(this List<T> inputList, Func<T, TRes> mfunc)
        {

            var returnList = new List<TRes>();
            
            foreach (var item in inputList)
            {
                returnList.Add(mfunc(item));
            }
            return returnList;
        }



        public static List<T> MyDistinct<T>(this List<T> inputList)
        {

            var returnList = new List<T>();


            foreach (var item in inputList)
            {
                if (!returnList.Contains(item))
                {
                    returnList.Add(item);
                }
            }

            return returnList;
        }

        public static List<T> MyOrderBy<T>(this List<T> inputList,Comparison<T> comp)
        {

            var returnList = new List<T>();


            foreach (T item in inputList)
            {
                int i = 0;
                while(i<inputList.Count&&i<returnList.Count && comp(item, returnList[i])<0)
                {
                    i++;
                }
            }

            return returnList;
        }

        public static List<T> MyTake<T>(this List<T> inputList, int countTake)
        {

            var returnList = new List<T>();

            for (int i = 0; i < countTake&& i <inputList.Count; i++)
            {
                returnList.Add(inputList[i]);
            }
            

           

            return returnList;

        }

        public static List<T> MySkip<T>(this List<T> inputList, int countTake)
        {

            var returnList = new List<T>();

            for (int i = countTake; i < inputList.Count; i++)
            {
                returnList.Add(inputList[i]);
            }




            return returnList;

        }
        public static List<T> MyReverse<T>(this List<T> inputList)
        {

            var returnList = new List<T>();
            
            for (int i = inputList.Count-1; i >= 0; i-=1)
            {
                returnList.Add(inputList[i]);
            }
            return returnList;

        }
        public static T MyFirst<T>(this List<T> inputList)
        {

            if (inputList.Count != 0)
            {
                return inputList[0];
            }
            throw new Exception("kein erstes element vorhanden");

        }
        public static T MyFirstorDefault<T>(this List<T> inputList)
        {
            return inputList.Count!=0 ? inputList[0]: default(T);
        }
        public static T MyElementAt<T>(this List<T> inputList, int n)
        {

            if (inputList.Count > n)
            {
                return inputList[n];
            }
            return default(T);

        }

        public static void MyPrintList<T>(this List<T>? retVals)
        {
            
            Console.Write("List: ");
            for (int i =0; i < retVals.Count;i++)
            {
                Console.Write(retVals[i].ToString());
                if (i != retVals.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("");

        }

    }
}
