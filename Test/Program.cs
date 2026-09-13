namespace Test
{
    public class Father
    {
        public virtual void Speak()
        {
            Console.WriteLine("父亲说话了");
        }
    }
    public class Son : Father
    {
        public void Speak()
        {
            Console.WriteLine("儿子说话了");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Father son = new Son();
            son.Speak();
            (son as Son).Speak();
        }
    }
}
