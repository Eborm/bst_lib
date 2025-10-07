using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace bst_lib_namespace
{
    public class bst_lib
    {
        //console colors
        private System.ConsoleColor BackgroundColor;
        private System.ConsoleColor ForegroundColor;

        //setting up detection and sleepingbeauty classes
        private detection _detection = new detection();
        private sleepingbeauty _sb = new sleepingbeauty();
        private double x = 0.003;

        //startup animation
        private static string startup =
@"          _____                    _____                _____           
         /\    \                  /\    \              /\    \          
        /::\    \                /::\    \            /::\    \         
       /::::\    \              /::::\    \           \:::\    \        
      /::::::\    \            /::::::\    \           \:::\    \       
     /:::/\:::\    \          /:::/\:::\    \           \:::\    \      
    /:::/__\:::\    \        /:::/__\:::\    \           \:::\    \     
   /::::\   \:::\    \       \:::\   \:::\    \          /::::\    \    
  /::::::\   \:::\    \    ___\:::\   \:::\    \        /::::::\    \   
 /:::/\:::\   \:::\ ___\  /\   \:::\   \:::\    \      /:::/\:::\    \  
/:::/__\:::\   \:::|    |/::\   \:::\   \:::\____\    /:::/  \:::\____\ 
\:::\   \:::\  /:::|____|\:::\   \:::\   \::/    /   /:::/    \::/    / 
 \:::\   \:::\/:::/    /  \:::\   \:::\   \/____/   /:::/    / \/____/  
  \:::\   \::::::/    /    \:::\   \:::\    \      /:::/    /           
   \:::\   \::::/    /      \:::\   \:::\____\    /:::/    /            
    \:::\  /:::/    /        \:::\  /:::/    /    \::/    /             
     \:::\/:::/    /          \:::\/:::/    /      \/____/              
      \::::::/    /            \::::::/    /                            
       \::::/    /              \::::/    /                             
        \::/    /                \::/    /                              
         \/____/                  \/____/                               
                                                                        
          _____            _____                    _____               
         /\    \          /\    \                  /\    \              
        /::\____\        /::\    \                /::\    \             
       /:::/    /        \:::\    \              /::::\    \            
      /:::/    /          \:::\    \            /::::::\    \           
     /:::/    /            \:::\    \          /:::/\:::\    \          
    /:::/    /              \:::\    \        /:::/__\:::\    \         
   /:::/    /               /::::\    \      /::::\   \:::\    \        
  /:::/    /       ____    /::::::\    \    /::::::\   \:::\    \       
 /:::/    /       /\   \  /:::/\:::\    \  /:::/\:::\   \:::\ ___\      
/:::/____/       /::\   \/:::/  \:::\____\/:::/__\:::\   \:::|    |     
\:::\    \       \:::\  /:::/    \::/    /\:::\   \:::\  /:::|____|     
 \:::\    \       \:::\/:::/    / \/____/  \:::\   \:::\/:::/    /      
  \:::\    \       \::::::/    /            \:::\   \::::::/    /       
   \:::\    \       \::::/____/              \:::\   \::::/    /        
    \:::\    \       \:::\    \               \:::\  /:::/    /         
     \:::\    \       \:::\    \               \:::\/:::/    /          
      \:::\    \       \:::\    \               \::::::/    /           
       \:::\____\       \:::\____\               \::::/    /            
        \::/    /        \::/    /                \::/    /             
         \/____/          \/____/                  \/____/";
        private List<char> bstlibtext = startup.ToList();

        //setting up the text functions
        private Dictionary<Tuple<int, string>, Tuple<string, string>> _TextDictonary = new Dictionary<Tuple<int, string>, Tuple<string, string>> { { new Tuple<int, string>(0, "empty"), new Tuple<string, string>("You called the wrong text rip", "-") } };
        private int selectedtext = -1;
        private int textcount = 0;

        public bst_lib(System.ConsoleColor BackgroundColor = ConsoleColor.Black, System.ConsoleColor ForegroundColor = ConsoleColor.White)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;
            Console.SetWindowSize(10, 10);
            for (int i = 0; i < bstlibtext.Count; i++)
            {
                Console.Write(bstlibtext[i]);
                _sb.NOP(x);
            }
            _sb.NOP(0.5);
            Console.Clear();
        }

        public bst_lib(bool disable_startup_animation, System.ConsoleColor BackgroundColor = ConsoleColor.Black, System.ConsoleColor ForegroundColor = ConsoleColor.White)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;
            if (disable_startup_animation == false)
            {
                for (int i = 0; i < bstlibtext.Count; i++)
                {
                    Console.Write(bstlibtext[i]);
                    _sb.NOP(x);
                }
                _sb.NOP(0.5);
                Console.Clear();
            }
        }
    
        
        public void add_text(string text, string functionname="-")
        {
            textcount++;
            _TextDictonary.Add(new Tuple<int, string>(textcount, ""), new Tuple<string, string>(text, functionname));
        }

        public void add_text(string keyword, string text, string functionname)
        {
            textcount++;
            _TextDictonary.Add(new Tuple<int, string>(textcount, keyword), new Tuple<string, string>(text, functionname));
        }


    }
}
