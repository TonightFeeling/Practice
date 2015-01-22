using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class dfs
    {
        private static int s = 80;
        public static bool FindSum()
        {
            bool have = false;
            Random rand = new Random();
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < 20; i++)
            //{
            //    numbers.Add(rand.Next(-10000, 10000));
            //}

            Console.WriteLine("SUMDFS: " + SumDFS(numbers, 0, 0));
            Console.WriteLine("DFS :" + DfsSum(numbers, 0, 0));
            return have;
        }

        public static int SumDFS(List<int> nums, int sum, int k)
        {
            if (sum != s)
            {
                if (k < nums.Count)
                {

                    SumDFS(nums, sum, k + 1);
                    SumDFS(nums, sum + nums[k], k + 1);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return sum;
            }
            return -1;
        }

        public static bool DfsSum(List<int> nums, int sum, int i)
        {
            if (i == nums.Count)
            {
                return sum == s;
            }

            if (DfsSum(nums, sum, i + 1)) return true;

            if (DfsSum(nums, sum + nums[i], i + 1)) return true;

            return false;

            //nao zi ben yao duo yong 。。。 zhuan zu

        }

    }
}
