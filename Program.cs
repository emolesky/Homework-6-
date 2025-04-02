namespace Removing
{
     public class Program
    {
       public static void Main(string[] args)
        {
            int[] nums = [3, 2, 2, 3];
            int val = 3;

            Solution aSolution = new Solution( nums, val);
            int result = aSolution.RemoveElement(nums, val);

            Console.WriteLine(result);
        }
    }
}
