﻿using System;

namespace ShiverMonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Shiver())
                game.Run();
        }
    }
}
