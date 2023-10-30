using Dedhub.UI;
using Screen = Dedhub.UI.Screen;
namespace Dedhub
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Screen.Init();
        }    
    }
}

