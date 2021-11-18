using System.Collections.Generic;
using System;
using System.Numerics;
using Raylib_cs;

namespace VinterProjekt
{
  class Program
  {

    static void Main(string[] args)
    {
      int RECS_WIDTH = 25;
      int RECS_HEIGHT = 25;
      int MAX_RECS_X = 250 / RECS_WIDTH;
      int MAX_RECS_Y = 500 / RECS_HEIGHT;

      Rectangle[] rects = new Rectangle[MAX_RECS_X * MAX_RECS_Y];
      // List<Rectangle> rects = new List<Rectangle>();

      Rectangle playerRect = new Rectangle(150, 150, RECS_WIDTH, RECS_HEIGHT);

      int width = 800;
      int height = 600;

      int gameWidth = width - RECS_WIDTH;
      int gameHeight = height - RECS_HEIGHT;

      Raylib.InitWindow(width, height, "Hello World");
      Raylib.SetTargetFPS(60);


      for (int y = 0; y < MAX_RECS_Y; y++)
      {
        for (int x = 0; x < MAX_RECS_X; x++)
        {
          rects[y * MAX_RECS_X + x].x = 250 + RECS_WIDTH * x;
          rects[y * MAX_RECS_X + x].y = 50 + RECS_HEIGHT * y;
          rects[y * MAX_RECS_X + x].width = RECS_WIDTH;
          rects[y * MAX_RECS_X + x].height = RECS_HEIGHT;
        }
      }

      Raylib.SetExitKey(KeyboardKey.KEY_ESCAPE);

      while (!Raylib.WindowShouldClose())
      {

        Vector2 mousePos = Raylib.GetMousePosition();
        bool areOverlapping = Raylib.CheckCollisionPointRec(mousePos, playerRect);


        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerRect.y != gameHeight)
        {
          playerRect.y += Convert.ToSingle(5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && playerRect.y != 0)
        {
          playerRect.y -= Convert.ToSingle(5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerRect.x != gameWidth)
        {
          playerRect.x += Convert.ToSingle(5);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerRect.x != 0)
        {
          playerRect.x -= Convert.ToSingle(5);
        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);


        for (int i = 0; i < MAX_RECS_X * MAX_RECS_Y; i++)
        {
          Raylib.DrawRectangleRec(rects[i], Color.WHITE);
          Raylib.DrawRectangleLinesEx(rects[i], 1, Color.BLACK);
        }

        Raylib.DrawText(mousePos.ToString(), 10, 10, 25, Color.ORANGE);

        Raylib.DrawText(playerRect.y.ToString(), 10, 40, 20, Color.ORANGE);
        Raylib.DrawText(playerRect.x.ToString(), 60, 40, 20, Color.ORANGE);

        Raylib.DrawText(areOverlapping.ToString(), 10, 60, 20, Color.BLACK);

        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);

        Raylib.EndDrawing();

      }
    }

  }
}

