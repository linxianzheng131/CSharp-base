using System;

namespace Lesson14_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");

            #region 知识点一 选择排序基本原理
            // 8 7 1 5 4 2 6 3 9
            // 新建中间商
            // 依次比较
            // 找出极值（最大或最小）
            // 放入目标位置
            // 比较n轮
            #endregion

            #region 知识点二 代码实现
            //实现升序 把 大的 放在最后面
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };

            ////第一步 申明一个中间商 来记录索引
            ////每一轮开始 默认第一个都是极值
            //int index = 0;
            ////第二步
            ////依次比较
            //for (int n = 1; n < arr.Length; n++)
            //{
            //    //第三步
            //    //找出极值（最大值）
            //    if( arr[index] < arr[n] )
            //    {
            //        index = n;
            //    }
            //}

            ////第四步 放入目标位置
            ////Length - 1 - 轮数
            ////如果当前极值所在位置 就是目标位置 那就没必要交换了
            //if( index != arr.Length - 1 - 轮数 )
            //{
            //    int temp = arr[index];
            //    arr[index] = arr[arr.Length - 1 - 轮数];
            //    arr[arr.Length - 1 - 轮数] = temp;
            //}

            //第五步 比较m轮
            int index;
            int temp;
            for (int m = 0; m < arr.Length; m++)
            {
                //第一步 申明一个中间商 来记录索引
                //每一轮开始 默认第一个都是极值
                index = 0;//不要忘了 每一轮开始 都要重置中间商的值

                //如果是
                //index = m;

                //第二步
                //依次比较
                // -m的目的 是排除上一轮 已经放好位置的数
                for (int n = 1; n < arr.Length - m; n++)
                {
                    //第三步
                    //找出极值（最大值）
                    if (arr[index] < arr[n])
                    {
                        index = n;
                    }
                }

                //第四步 放入目标位置
                //Length - 1 - 轮数
                //如果当前极值所在位置 就是目标位置 那就没必要交换了
                if (index != arr.Length - 1 - m)//这里写成 m 是一样的 因为 m 和 arr.Length - 1 - m 是对称的
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            #endregion

            #region 另外一种选择排序
            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index1 = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[index1])
                    {
                        index = j;
                    }

                }
                Console.WriteLine("index: " + arr[index1]);
                if (index1 != i)
                {
                    int temp1 = arr[index1];
                    arr[index1] = arr[i];
                    arr[i] = temp1;
                }

            }


            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            Console.WriteLine("选择排序练习题");
            #region 练习题一
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印

            int[] array = new int[20];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //套路写法
            //两层循环
            //外层轮数
            for (int i = 0; i < array.Length; i++)
            {
                //初始索引
                index = 0;
                //内层寻找
                for (int j = 1; j < array.Length - i; j++)
                {
                    //记录极值
                    //这里决定了 找到极值的种类 
                    //只需要改这的条件 就可以改变 降序还是升序
                    if (array[index] > array[j])
                    {
                        index = j;
                    }
                }

                //内层循环外交换
                if (index != array.Length - 1 - i)
                {
                    temp = array[index];
                    array[index] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            #endregion

            //总结
            //基本概念
            // 新建中间商
            // 依次比较
            // 找出极值
            // 放入目标位置
            // 比较n轮

            //套路写法
            //两层循环
            //外层轮数
            //内层寻找
            //初始索引
            //记录极值
            //内存循环外交换
            
        }
    }
}
