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
      Board board = new Board();
      Pieces pieces = new Pieces();

      int RECS_WIDTH = 25;
      int RECS_HEIGHT = 25;

      int MAX_RECS_X = 250 / RECS_WIDTH;
      int MAX_RECS_Y = 500 / RECS_HEIGHT;

      Rectangle[] rects = new Rectangle[MAX_RECS_X * MAX_RECS_Y];

      Rectangle playerRect = new Rectangle(700, 100, RECS_WIDTH, RECS_HEIGHT);

      Console.WriteLine(rects);

      int gridXStart = 600;
      int gridYStart = 100;

      int height = 700;
      int width = 1400;

      int gameWidth = width - RECS_WIDTH;
      int gameHeight = height - RECS_HEIGHT;

      Raylib.InitWindow(width, height, "Hello World");
      Raylib.SetTargetFPS(60);

      Raylib.SetExitKey(KeyboardKey.KEY_ESCAPE);

      for (int y = 0; y < MAX_RECS_Y; y++)
      {
        for (int x = 0; x < MAX_RECS_X; x++)
        {
          rects[y * MAX_RECS_X + x].x = gridXStart + RECS_WIDTH * x;
          rects[y * MAX_RECS_X + x].y = gridYStart + RECS_HEIGHT * y;
          rects[y * MAX_RECS_X + x].width = RECS_WIDTH;
          rects[y * MAX_RECS_X + x].height = RECS_HEIGHT;
        }
      }


      while (!Raylib.WindowShouldClose())
      {
        // !Om man håller i, flyg till andra sidan...

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_S) && playerRect.y != 575)
        {
          playerRect.y += Convert.ToSingle(RECS_WIDTH);
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_W) && playerRect.y != gridYStart)
        {
          playerRect.y -= Convert.ToSingle(RECS_WIDTH);
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D) && playerRect.x != 825)
        {
          playerRect.x += Convert.ToSingle(RECS_WIDTH);
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A) && playerRect.x != gridXStart)
        {
          playerRect.x -= Convert.ToSingle(RECS_WIDTH);
        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);


        for (int i = 0; i < MAX_RECS_X * MAX_RECS_Y; i++)
        {
          Raylib.DrawRectangleRec(rects[i], Color.WHITE);
          Raylib.DrawRectangleLinesEx(rects[i], 1, Color.BLACK);
        }

        // !Pieces
        Raylib.DrawRectangleRec(pieces.I_RECT1, pieces.I_CYAN);
        Raylib.DrawRectangleRec(pieces.I_RECT2, pieces.I_CYAN);
        Raylib.DrawRectangleRec(pieces.I_RECT3, pieces.I_CYAN);
        Raylib.DrawRectangleRec(pieces.I_RECT4, pieces.I_CYAN);

        Raylib.DrawRectangleRec(pieces.O_RECT1, pieces.O_YELLOW);
        Raylib.DrawRectangleRec(pieces.O_RECT2, pieces.O_YELLOW);
        Raylib.DrawRectangleRec(pieces.O_RECT3, pieces.O_YELLOW);
        Raylib.DrawRectangleRec(pieces.O_RECT4, pieces.O_YELLOW);

        Raylib.DrawRectangleRec(pieces.S_RECT1, pieces.S_GREEN);
        Raylib.DrawRectangleRec(pieces.S_RECT2, pieces.S_GREEN);
        Raylib.DrawRectangleRec(pieces.S_RECT3, pieces.S_GREEN);
        Raylib.DrawRectangleRec(pieces.S_RECT4, pieces.S_GREEN);

        Raylib.DrawRectangleRec(pieces.Z_RECT1, pieces.Z_RED);
        Raylib.DrawRectangleRec(pieces.Z_RECT2, pieces.Z_RED);
        Raylib.DrawRectangleRec(pieces.Z_RECT3, pieces.Z_RED);
        Raylib.DrawRectangleRec(pieces.Z_RECT4, pieces.Z_RED);

        Raylib.DrawRectangleRec(pieces.L_RECT1, pieces.L_ORANGE);
        Raylib.DrawRectangleRec(pieces.L_RECT2, pieces.L_ORANGE);
        Raylib.DrawRectangleRec(pieces.L_RECT3, pieces.L_ORANGE);
        Raylib.DrawRectangleRec(pieces.L_RECT4, pieces.L_ORANGE);

        Raylib.DrawRectangleRec(pieces.J_RECT1, pieces.J_BLUE);
        Raylib.DrawRectangleRec(pieces.J_RECT2, pieces.J_BLUE);
        Raylib.DrawRectangleRec(pieces.J_RECT3, pieces.J_BLUE);
        Raylib.DrawRectangleRec(pieces.J_RECT4, pieces.J_BLUE);

        Raylib.DrawRectangleRec(pieces.T_RECT1, pieces.T_PURPLE);
        Raylib.DrawRectangleRec(pieces.T_RECT2, pieces.T_PURPLE);
        Raylib.DrawRectangleRec(pieces.T_RECT13, pieces.T_PURPLE);
        Raylib.DrawRectangleRec(pieces.T_RECT4, pieces.T_PURPLE);

        Raylib.DrawText(playerRect.y.ToString(), 10, 40, 20, Color.ORANGE);
        Raylib.DrawText(playerRect.x.ToString(), 60, 40, 20, Color.ORANGE);

        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);

        Raylib.EndDrawing();

      }

    }
  }
}

