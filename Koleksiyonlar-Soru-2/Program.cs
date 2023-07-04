using System;

namespace collections2{
    class Program{
        static void Main(string[] args)
        {
            int[] nums = new int[20];

            for(int i=0; i<20; ++i){
                Console.Write((i+1)+": ");
                int x = int.Parse(Console.ReadLine());
                nums[i] = x;
            }

            Array.Sort(nums);
            int s1 = Convert.ToInt32(nums[0]);
            int s2 = Convert.ToInt32(nums[1]);
            int s3 = Convert.ToInt32(nums[2]);
            int b1 = Convert.ToInt32(nums[19]);
            int b2 = Convert.ToInt32(nums[18]);
            int b3 = Convert.ToInt32(nums[17]);

            Console.WriteLine("Most 3 smallest number: "+s1+" "+s2+" "+s3+" Average:"+((s1+s2+s3)/3));
            Console.WriteLine("Most 3 biggest number: "+b1+" "+b2+" "+b3+" Average:"+((b1+b2+b3)/3));
            Console.WriteLine("Sum of averages: "+(((s1+s2+s3)/3)+((b1+b2+b3)/3)));
        }
    }
}