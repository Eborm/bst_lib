using bst_lib_namespace;

namespace test_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bst_lib bst = new bst_lib(true ,ConsoleColor.Black, ConsoleColor.White);
            bst.add_text("test", "Test [yes]", myfunction);
            bst.add_text("test2", "Test 2 [no]", myfunction2);
            bst.add_text("some text");
            bst.add_text("some text2");
            bst.set_shown_text(new List<int> {1, 0 ,2, 0, 3, 4});
            while (true)
            {
                bst.display_text();
            }

        }

        public static void myfunction()
        {
            Console.Clear();
            Console.WriteLine("Test function");
            Console.ReadLine();
        }

        public static void myfunction2()
        {
            Console.Clear();
            Console.WriteLine("Test function 2");
            Console.ReadLine();
        }
    }
}
