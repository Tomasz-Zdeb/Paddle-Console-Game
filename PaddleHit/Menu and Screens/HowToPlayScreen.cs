﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class HowToPlayScreen : ScreenBase
    {
        public int Screen(int width, int height,int temp)
        {
            //for relative content positioning
            int xStart = ((width + 2) - 57) / 2;
            int yStart = ((height + 2) - 18) / 2;

            startupDate = DateTime.Now;
            // main loop
            while (consoleKey != ConsoleKey.Enter)
            {

                mainClock = DateTime.Now - startupDate;

                OuterFrameDraw(width, height, '▓');
                InnerFrameDraw(xStart, yStart, '▒');
                DrawContent(xStart,yStart);
                DrawPressEnter(xStart, yStart, mainClock);
                DrawSideLines(xStart, yStart);

                CheckIfKeyIsPressed();
            }
            Console.Clear();
            return ((temp / 10) * 10);
        }
        private void DrawContent(int xStart, int yStart)
        {
            Console.SetCursorPosition(xStart + 5, yStart + 2);
            Console.Write("1) Use W/S or up/down arrow keys to move the");
            Console.SetCursorPosition(xStart + 5, yStart + 3);
            Console.Write("   paddles, be aware that game supports only");
            Console.SetCursorPosition(xStart + 5, yStart + 4);
            Console.Write("   clicking, you CAN NOT hold the key");
            Console.SetCursorPosition(xStart + 5, yStart + 6);
            Console.Write("2) Try to hit the ball with the paddle or You");
            Console.SetCursorPosition(xStart + 5, yStart + 7);
            Console.Write("   will lose the game if You miss");
            Console.SetCursorPosition(xStart + 5, yStart + 9);
            Console.Write("3) Central hit grants You straight shoot, that");
            Console.SetCursorPosition(xStart + 5, yStart + 10);
            Console.Write("   means the ball will move perpendicular to");
            Console.SetCursorPosition(xStart + 5, yStart + 11);
            Console.Write("   the paddles");
            Console.SetCursorPosition(xStart + 5, yStart + 13);
            Console.Write("4) Use setting to adjust gameplay to your needs");
        }
        private void DrawPressEnter(int xStart, int yStart, TimeSpan mainClock)
        {
            if (((int)mainClock.TotalSeconds) % 2 == 0)
            {
                Console.SetCursorPosition(xStart + 16, yStart + 15);
                Console.Write("Press ENTER to proceed... ");
            }
            else
            {
                Console.SetCursorPosition(xStart + 16, yStart + 15);
                Console.Write("                          ");
            }
        }
        private void DrawSideLines(int xStart, int yStart)
        {
            // left from top to bottom
            for (int i = yStart + 2; i < yStart + 15; i++)
            {
                Console.SetCursorPosition(xStart + 3, i);
                Console.Write("│");
            }
            // right from top to bottom
            for (int i = yStart + 2; i < yStart + 15; i++)
            {
                Console.SetCursorPosition(xStart + 53, i);
                Console.Write("│");
            }
        }
    }

}
