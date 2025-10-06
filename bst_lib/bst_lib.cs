namespace bst_lib
{
    public class bst_lib
    {
        private detection _detection = new detection();
        private int height = Console.WindowHeight;
        private int width = Console.WindowWidth;


        public bst_lib()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("B");
                }
            }

        }
    }
}
