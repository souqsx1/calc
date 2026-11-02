namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter which function you would like to use\n1. Binary \n2. Geometry/Vectors \n3. Matrices");
                string temp= Console.ReadLine();
                int input = 0;
                try { input = Convert.ToInt32(temp); }
                catch 
                { 
                    Console.WriteLine("MISINPUT");
                    Console.ReadLine();
                }
                Console.Clear();
                switch(input)
                {
                    case 1:
                        Binary();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        break;
                }
            }while (running);
        }
        static void Binary()
        {
            string input;
            int index = 0;
            Console.WriteLine("Enter first binary number: ");
            input = Console.ReadLine();
            int[] bin1 = new int [input.Length];
            foreach (char i in input)
            {
                if (i == '0' || i == '1')
                {
                    bin1[index] = i - '0';
                    index++;
                }
            }
            foreach (int i in bin1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
