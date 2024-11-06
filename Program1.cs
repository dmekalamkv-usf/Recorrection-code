using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            /* num_addition 
            Console.WriteLine("Hello, World!");*/
            int total = num_addition(38);
            Console.WriteLine(total);
            total = num_addition(0);
            Console.WriteLine(total);
            total = num_addition(9999);
            Console.WriteLine(total);

            Console.WriteLine();
            int[] nums= [0, 1, 0, 3, 12];
            Console.WriteLine(string.Join(", ", nums));
            int[] nums1 = zero_rearrangement(nums);
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine();

            int[] nums2 = [0, 1, 0, 3, 12,15,17,0,100,200,0,0,0];
            Console.WriteLine(string.Join(", ", nums2));
            int[] nums3 = zero_rearrangement(nums2);
            Console.WriteLine(string.Join(", ", nums2)); ; 

        }
       

        static int[] zero_rearrangement(int[] nums)
        {
            int zero, non_zero;
            int temp, j, i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == 0)
                {
                    zero = i;
                    j = i;
                    while (nums[j] == 0 && j < nums.Length - 1)
                    {
                        j++;

                    }

                    non_zero = j;
                    nums[zero] = nums[non_zero];
                    nums[non_zero] = 0;

                }
                i++;
            }

            return nums;
        }


        static int num_addition(int num)
        {

            int sum = 0;
            int digit;
            int left_over_num = num;
            while (left_over_num != 0)
            {
                digit = left_over_num % 10;
                left_over_num = (left_over_num / 10);
                sum = sum + digit;
            }
            if (sum >= 10) { sum = num_addition(sum); }
            return sum;
        }
    }

        


    
}
