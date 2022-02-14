using Raylib_cs;
using System;
using System.Collections.Generic;



namespace VinterProjekt
{
  public class Pieces
  {

    Random rand = new Random();
    List<string> pieces = new List<string>() { "I", "T", "Z", "S", "O", "L", "J" };
    // List<Rectangle> pieces = new List<Rectangle>() { };

    public Color J_BLUE = new Color(3, 65, 174, 255);
    public Color S_GREEN = new Color(114, 203, 59, 255);
    public Color Z_RED = new Color(255, 50, 19, 255);
    public Color O_YELLOW = new Color(255, 213, 0, 255);
    public Color L_ORANGE = new Color(255, 151, 28, 255);

    public Color I_CYAN = new Color(0, 197, 223, 255);
    public Color T_PURPLE = new Color(167, 58, 165, 255);

    //   !R Rect
    public Rectangle I_RECT1 = new Rectangle(500, 100, 25, 25);
    public Rectangle I_RECT2 = new Rectangle(500, 125, 25, 25);
    public Rectangle I_RECT3 = new Rectangle(500, 150, 25, 25);
    public Rectangle I_RECT4 = new Rectangle(500, 175, 25, 25);

    //   !O Rect
    public Rectangle O_RECT1 = new Rectangle(550, 125, 25, 25);
    public Rectangle O_RECT2 = new Rectangle(575, 125, 25, 25);
    public Rectangle O_RECT3 = new Rectangle(550, 100, 25, 25);
    public Rectangle O_RECT4 = new Rectangle(575, 100, 25, 25);

    //   !S Rect
    public Rectangle S_RECT1 = new Rectangle(425, 125, 25, 25);
    public Rectangle S_RECT2 = new Rectangle(425, 100, 25, 25);
    public Rectangle S_RECT3 = new Rectangle(400, 100, 25, 25);
    public Rectangle S_RECT4 = new Rectangle(450, 125, 25, 25);

    //   !Z Rect
    public Rectangle Z_RECT1 = new Rectangle(325, 125, 25, 25);
    public Rectangle Z_RECT2 = new Rectangle(300, 125, 25, 25);
    public Rectangle Z_RECT3 = new Rectangle(325, 100, 25, 25);
    public Rectangle Z_RECT4 = new Rectangle(350, 100, 25, 25);

    //   !L Rect
    public Rectangle L_RECT1 = new Rectangle(250, 100, 25, 25);
    public Rectangle L_RECT2 = new Rectangle(250, 125, 25, 25);
    public Rectangle L_RECT3 = new Rectangle(250, 150, 25, 25);
    public Rectangle L_RECT4 = new Rectangle(275, 150, 25, 25);

    //   !J Rect
    public Rectangle J_RECT1 = new Rectangle(200, 100, 25, 25);
    public Rectangle J_RECT2 = new Rectangle(200, 125, 25, 25);
    public Rectangle J_RECT3 = new Rectangle(200, 150, 25, 25);
    public Rectangle J_RECT4 = new Rectangle(175, 150, 25, 25);

    //   !T Rect
    public Rectangle T_RECT1 = new Rectangle(150, 125, 25, 25);
    public Rectangle T_RECT2 = new Rectangle(125, 100, 25, 25);
    public Rectangle T_RECT3 = new Rectangle(125, 125, 25, 25);
    public Rectangle T_RECT4 = new Rectangle(100, 125, 25, 25);


    // public void RandomPieces()
    // {
    //   // int i = rand.Next(7);
    //   for (int i = 0; i < pieces.Count; i++)
    //   {
    //     pieces[i];
    //   }

    // }

    public void DrawL()
    {
      Raylib.DrawRectangleRec(L_RECT1, L_ORANGE);
      Raylib.DrawRectangleRec(L_RECT2, L_ORANGE);
      Raylib.DrawRectangleRec(L_RECT3, L_ORANGE);
      Raylib.DrawRectangleRec(L_RECT4, L_ORANGE);
    }

    public void DrawZ()
    {
      Raylib.DrawRectangleRec(Z_RECT1, Z_RED);
      Raylib.DrawRectangleRec(Z_RECT2, Z_RED);
      Raylib.DrawRectangleRec(Z_RECT3, Z_RED);
      Raylib.DrawRectangleRec(Z_RECT4, Z_RED);
    }


    public void DrawS()
    {
      Raylib.DrawRectangleRec(S_RECT1, S_GREEN);
      Raylib.DrawRectangleRec(S_RECT2, S_GREEN);
      Raylib.DrawRectangleRec(S_RECT3, S_GREEN);
      Raylib.DrawRectangleRec(S_RECT4, S_GREEN);

    }


    public void DrawO()
    {
      Raylib.DrawRectangleRec(O_RECT1, O_YELLOW);
      Raylib.DrawRectangleRec(O_RECT2, O_YELLOW);
      Raylib.DrawRectangleRec(O_RECT3, O_YELLOW);
      Raylib.DrawRectangleRec(O_RECT4, O_YELLOW);
    }

    public void DrawI()
    {

      Raylib.DrawRectangleRec(I_RECT1, I_CYAN);
      Raylib.DrawRectangleRec(I_RECT2, I_CYAN);
      Raylib.DrawRectangleRec(I_RECT3, I_CYAN);
      Raylib.DrawRectangleRec(I_RECT4, I_CYAN);
    }

    public void DrawJ()
    {
      Raylib.DrawRectangleRec(J_RECT1, J_BLUE);
      Raylib.DrawRectangleRec(J_RECT2, J_BLUE);
      Raylib.DrawRectangleRec(J_RECT3, J_BLUE);
      Raylib.DrawRectangleRec(J_RECT4, J_BLUE);
    }

    public void DrawT()
    {
      Raylib.DrawRectangleRec(T_RECT1, T_PURPLE);
      Raylib.DrawRectangleRec(T_RECT2, T_PURPLE);
      Raylib.DrawRectangleRec(T_RECT3, T_PURPLE);
      Raylib.DrawRectangleRec(T_RECT4, T_PURPLE);
    }
  }
}