using System;
using System.Numerics;
using Raylib_cs;

namespace VinterProjekt
{
  class Program
  {
    public static Rectangle playerRect = new Rectangle(150, 150, 50, 50);

    static void Main(string[] args)
    {
      int width = 1200;
      int height = 600;

      int gameWidth = width - 50;
      int gameHeight = height - 50;

      Raylib.InitWindow(width, height, "Hello World");

      Rectangle bullet = new Rectangle(playerRect.x, playerRect.y, 10, 10);
      Rectangle newBullet = new Rectangle(playerRect.x + 10, playerRect.y, 10, 10);

      Color newPink = new Color(255, 105, 180, 255);

      Raylib.SetExitKey(KeyboardKey.KEY_ESCAPE);
      bool shooting = false;

      while (!Raylib.WindowShouldClose())
      {

        Vector2 mousePos = Raylib.GetMousePosition();
        bool areOverlapping = Raylib.CheckCollisionPointRec(mousePos, playerRect);


        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerRect.y != gameHeight)
        {
          playerRect.y += Convert.ToSingle(1);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && playerRect.y != 0)
        {
          playerRect.y -= Convert.ToSingle(1);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerRect.x != gameWidth)
        {
          playerRect.x += Convert.ToSingle(1);
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerRect.x != 0)
        {
          playerRect.x -= Convert.ToSingle(1);
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
          shooting = true;
          bullet.x += 2;
          newBullet.x += 2;

        }

        if (shooting)
        {

        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);

        Raylib.DrawText(mousePos.ToString(), 10, 10, 25, Color.ORANGE);

        Raylib.DrawText(playerRect.y.ToString(), 10, 40, 20, Color.ORANGE);
        Raylib.DrawText(playerRect.x.ToString(), 60, 40, 20, Color.ORANGE);

        Raylib.DrawText(areOverlapping.ToString(), 10, 60, 20, Color.BLACK);

        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);
        Raylib.DrawRectangleRec(newBullet, Color.SKYBLUE);
        Raylib.DrawRectangleRec(bullet, Color.SKYBLUE);

        Raylib.EndDrawing();

      }
    }

  }
}

