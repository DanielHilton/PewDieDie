using System;

namespace PewDieDie
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (PewDieDie game = new PewDieDie())
            {
                game.Run();
            }
        }
    }
#endif
}

