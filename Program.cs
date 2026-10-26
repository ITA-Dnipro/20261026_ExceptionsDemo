namespace _20261026_ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InputAWithExceptions();

            int b = 100;

            try
            {
                int c = Div(a, b);

                Console.WriteLine($"{b} / {a} = {c}");
            }
            catch (WrongArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }            
//            InputAWithoutExceptions();
        }

        public static int Div(int a, int b)
        {
            //if (a == 0)
            //{
            //    // генерація власного винятку

            //    throw new WrongArgumentException();
            //}

            int res = 0;

            try
            {
                res = b / a;
            }
            catch (DivideByZeroException ex)
            {
                throw new WrongArgumentException(ex);
            }

            return res;
        }

        private static int InputAWithoutExceptions()
        {
            int a = 0;
            bool isOk = false;
            do
            {
                Console.Write("a = ?");
                string s1 = Console.ReadLine();
                
                isOk = int.TryParse(s1, out a);
                if (isOk)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"a = {a}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!isOk);

            return a;
        }

        private static int InputAWithExceptions()
        {
            int a = 0;
            bool isOk = false;
            do
            {
                Console.Write("a = ?");
                string s1 = Console.ReadLine();
                try
                {
                    a = int.Parse(s1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"a = {a}");
                    isOk = true;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("The number is too large or too small. Please enter a valid integer.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!isOk);

            return a;
        }
    }
}
