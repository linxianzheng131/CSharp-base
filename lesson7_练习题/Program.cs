using System.Reflection.Metadata.Ecma335;

namespace lesson7_练习题
{
    internal class Program
    {
        static int[] Dif(int a)
        {
            int P=3;
            int b = a * a * P;
            int c = 2*a * P;
           
            return new int[] { b,c};
            
        }
        static int[] Calc(int a, int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            //int[] arr = { sum, avg };
            //return arr;
            // 5  
            // 如果用数组作为返回值出去 那么前提是 使用者 知道这个数组的规则
            return new int[] { sum, avg };
        }
        static void Ints(int[] shu)
        {
            int sum = 0;
            int avg = 0;
            int max = 0;
            int min = shu[0];
            for(int i=0;i<shu.Length;++i)
            {
                if (max < shu[i])
                {
                    max = shu[i];
                }
                if (min > shu[i])
                {
                    min = shu[i];
                }
                sum += shu[i];
            }
            avg= sum / shu.Length;
            
            Console.WriteLine("{0}{1}{2}{3}",max,min,avg,sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入");
            int[] f = Dif(1);
            Console.WriteLine(f[0]);

            int[] arr = Calc(5, 7);
            Console.WriteLine(arr[0] + " " + arr[1]);


            Ints(new int[] { 1,2,3,4});
        }
    }
}
