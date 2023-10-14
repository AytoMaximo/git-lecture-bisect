using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisect
{
    internal class BinarySearch
    {
        public static int Perform(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right) 
            { 
                int mid = (left + right) / 2; 

                if (arr[mid] == target)
                {
                    //мы нашли элемент!
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; //ищем дальше в правой части
                }
                else
                {
                    right = mid - 1; //ищем дальше в левой части
                }
            }

            return -1;
        }
    }
}
