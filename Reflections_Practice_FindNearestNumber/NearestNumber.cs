using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflections_Practice_FindNearestNumber
{
    public class NearestNumber
    {
        public int n;
        public NearestNumber(int number)
        {
            this.n = number;
        }
        public static int FindNearestNumber(int number)
        {
            int absnumber=Math.Abs(number);
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
            return(Math.Sign(number)* closestNumber);
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
}
