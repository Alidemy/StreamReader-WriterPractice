using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training.ExtensionMethodException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] nums = new int[] { 1, 2, 3 };
                Console.WriteLine(nums[10]);
            }
            catch (Exception ex)
            {
                ex.SaveToFile();
            }
        }
    }
}
