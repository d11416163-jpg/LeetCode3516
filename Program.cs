namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("輸入3個人的整數");
            string r1 = Console.ReadLine();
            string r2 = Console.ReadLine();
            string r3 = Console.ReadLine();
            int x = Convert.ToInt32(r1);
            int y = Convert.ToInt32(r2);
            int z = Convert.ToInt32(r3);

            Console.WriteLine(findClosest(x, y, z));

            int findClosest(int x, int y, int z)
            {
                //1.輸入
                //算出X和y到z的距離

                int dx = x - z;
                int dy = y - z;
                //2.處理距離 算絕對值

                if (dx < 0) dx = -dx;
                if (dy < 0) dy = -dy;

                //3.輸出

                if (dx < dy)
                {
                    return 1;
                }
                else if (dy < dx)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}