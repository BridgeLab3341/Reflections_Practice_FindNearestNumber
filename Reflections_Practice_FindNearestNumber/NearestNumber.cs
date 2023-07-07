using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections_Practice_FindNearestNumber
{
    public class NearestNumber
    {
        public static int FindNearestNumber(int n)
        {
            int absnumber=Math.Abs(n);
            int closestNumber = Int32.MaxValue;
            int minDifference = Int32.MaxValue;
           for(int i = absnumber; i <= absnumber+10; i++)
            {
                if(IsEvenNumber(i))
                {
                    int difference = Math.Abs(absnumber - i);
                    if(difference < minDifference)
                    {
                        closestNumber = i;
                        minDifference = difference;
                    }
                    else if(difference ==  minDifference && i < closestNumber)
                    {
                        closestNumber = i;
                    }
                }
           }
            return(Math.Sign(n)* closestNumber);
        }
        public static bool IsEvenNumber(int number)
        {
            while(number != 0)
            {
                int digit=number % 10;
                if(digit%2 !=0 )
                {
                    return false;
                }
                number/=10;
            }
            return true;
        }
    }
    public class NearestEvenNumberFinder
    {
        public static int FindNearestEvenNumber(int number)
        {
            return 0;
        }
    }
}
