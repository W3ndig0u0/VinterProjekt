using System;
using Raylib_cs;
using System.Numerics;


namespace VinterProjekt
{
  class Program
  {

    static void Main(string[] args)
    {
      int height = 700;
      int width = 1400;
      // Texture2D wallpapperTexture = Raylib.LoadTexture(@"tetris3.png");

      Raylib.InitWindow(width, height, "Tetris - Jing Xu");
      Raylib.SetTargetFPS(120);

      StartMenu Start = new StartMenu();
      int intro = 0;

      while (!Raylib.WindowShouldClose())
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        intro += 5;

        if (intro < 1000)
        {
          Raylib.DrawRectangle(0, 0, 1400, 700, Color.DARKBLUE);
          Raylib.DrawText("Tetris © 1985~2021 Tetris Holding.", 370, 520, 20, Color.BLACK);
          Raylib.DrawText("Tetris logos, Tetris theme song and Tetriminos are trademarks of Tetris Holding.", 370, 540, 20, Color.BLACK);
          Raylib.DrawText("The Tetris trade dress is owned by Tetris Holding.", 370, 560, 20, Color.BLACK);
          Raylib.DrawText("Licensed to The Tetris Company.", 370, 580, 20, Color.BLACK);
          Raylib.DrawText("Tetris Game Design by Alexey Pajitnov.", 370, 600, 20, Color.BLACK);
          Raylib.DrawText("Tetris Logo Design by Roger Dean.", 370, 620, 20, Color.BLACK);
          Raylib.DrawText("All Rights Reserved.", 370, 640, 20, Color.BLACK);
        }
        else if (intro < 2000)
        {
          Raylib.DrawRectangle(0, 0, 1400, 700, Color.RED);
        }

        else if (intro < 3000)
        {
          Start.Menu();
        }

        Raylib.EndDrawing();
      }
    }
  }
}