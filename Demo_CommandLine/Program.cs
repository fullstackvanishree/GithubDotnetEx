namespace Demo_CommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command line args");
            for(int i=0;i<args.Length;i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}