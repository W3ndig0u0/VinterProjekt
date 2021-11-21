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

      Raylib.InitWindow(width, height, "Tetris - Jing Xu");
      Raylib.SetTargetFPS(120);

      StartMenu Start = new StartMenu();
      int intro = 0;

      Image tetrisImg = Raylib.LoadImage(@"Tetris.png");
      Image wallpapperTetris = Raylib.LoadImage(@"Background2.png");
      Raylib.ImageResize(ref wallpapperTetris, 1400, 700);

      Texture2D tetrisTexture = Raylib.LoadTextureFromImage(tetrisImg);
      Texture2D wallpapperTetrisTexture = Raylib.LoadTextureFromImage(wallpapperTetris);

      while (!Raylib.WindowShouldClose())
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        intro += 5;

        // !FAde in eller nåt
        if (intro < 500)
        {
          // Raylib.DrawRectangle(0, 0, 1400, 700, Color.DARKBLUE);
          Raylib.DrawTexture(wallpapperTetrisTexture, 0, 0, Color.WHITE);
          Raylib.DrawTexture(tetrisTexture, 550, 150, Color.WHITE);
        }

        else if (intro < 1000)
        {
          Raylib.DrawTexture(wallpapperTetrisTexture, 0, 0, Color.WHITE);
          Raylib.DrawTexture(tetrisTexture, 550, 150, Color.WHITE);
          Raylib.DrawText("Tetris © 1985~2021 Tetris Holding.", 370, 460, 20, Color.BLACK);
          Raylib.DrawText("Tetris logos, Tetris theme song and Tetriminos are trademarks of Tetris Holding.", 370, 480, 20, Color.BLACK);
          Raylib.DrawText("The Tetris trade dress is owned by Tetris Holding.", 370, 500, 20, Color.BLACK);
          Raylib.DrawText("Licensed to The Tetris Company.", 370, 520, 20, Color.BLACK);
          Raylib.DrawText("Tetris Game Design by Alexey Pajitnov.", 370, 540, 20, Color.BLACK);
          Raylib.DrawText("Tetris Logo Design by Roger Dean.", 370, 560, 20, Color.BLACK);
          Raylib.DrawText("All Rights Reserved.", 370, 580, 20, Color.BLACK);

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