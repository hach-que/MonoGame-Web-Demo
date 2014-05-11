using System;

namespace Demo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Don't wrap this in a using() because that will dispose
            // the game object.  Unlike a normal console application,
            // we exit Main() and the game continues running.
            var game = new DemoGame();

            // This kicks of the asynchronous game loop and
            // returns immediately for the Web platform.
            game.Run();
        }
    }
}