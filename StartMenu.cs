using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjekt
{
  public class StartMenu
  {
    public void Menu()
    {

      Pieces pieces = new Pieces();
      GamePlay game = new GamePlay();

      Rectangle StartBlock = new Rectangle(0, 0, 1400, 60);
      Rectangle EndBlock = new Rectangle(0, 660, 1400, 60);

      Rectangle startButton = new Rectangle(300, 200, 1100, 80);
      Rectangle profileButton = new Rectangle(300, 290, 1100, 80);
      Rectangle settingButton = new Rectangle(300, 380, 1100, 80);
      Rectangle aboutButton = new Rectangle(300, 470, 1100, 80);

      Rectangle exitButton = new Rectangle(0, 70, 90, 50);
      Rectangle profile = new Rectangle(1220, 5, 170, 50);

      Rectangle facebookButton = new Rectangle(1190, 650, 50, 50);
      Rectangle twitterButton = new Rectangle(1260, 650, 50, 50);
      Rectangle githubButton = new Rectangle(1330, 650, 50, 50);

      Rectangle newScreen = new Rectangle(3000, 0, 1400, 700);

      // !Icons
      Image githubImg = Raylib.LoadImage(@"Github.png");
      Raylib.ImageResize(ref githubImg, 30, 30);
      Texture2D githubTexture = Raylib.LoadTextureFromImage(githubImg);

      Image facebookImg = Raylib.LoadImage(@"Facebook.png");
      Raylib.ImageResize(ref facebookImg, 30, 30);
      Texture2D facebookTexture = Raylib.LoadTextureFromImage(facebookImg);

      Image twitterImg = Raylib.LoadImage(@"Twitter.png");
      Raylib.ImageResize(ref twitterImg, 40, 40);
      Texture2D twitterTexture = Raylib.LoadTextureFromImage(twitterImg);


      Image gameImg = Raylib.LoadImage(@"GameIcon.png");
      Image profileImg = Raylib.LoadImage(@"Profile.png");
      Image settingsImg = Raylib.LoadImage(@"Settings.png");
      Image aboutImg = Raylib.LoadImage(@"About.png");

      Raylib.ImageResize(ref gameImg, 60, 60);
      Raylib.ImageResize(ref profileImg, 60, 60);
      Raylib.ImageResize(ref settingsImg, 60, 60);
      Raylib.ImageResize(ref aboutImg, 60, 60);

      Texture2D gameImgTextrure = Raylib.LoadTextureFromImage(gameImg);
      Texture2D profileImgTextrure = Raylib.LoadTextureFromImage(profileImg);
      Texture2D settingsImgTextrure = Raylib.LoadTextureFromImage(settingsImg);
      Texture2D aboutImgTextrure = Raylib.LoadTextureFromImage(aboutImg);


      Image wallpapperMenu = Raylib.LoadImage(@"Background3.png");
      Raylib.ImageResize(ref wallpapperMenu, 1400, 700);
      Texture2D wallpapperMenuTextrure = Raylib.LoadTextureFromImage(wallpapperMenu);

      // !Sound
      Sound clickSound = Raylib.LoadSound("Hover.wav");
      Music bgm = Raylib.LoadMusicStream("MenuBgm1.mp3");

      Font f1 = Raylib.LoadFont(@"Roboto-Bold.ttf");

      while (!Raylib.WindowShouldClose())
      {
        Vector2 mousePos = Raylib.GetMousePosition();
        Raylib.PlayMusicStream(bgm);
        Raylib.UpdateMusicStream(bgm);
        Raylib.SetMusicVolume(bgm, 0.5f);

        bool areOverlappingStart = Raylib.CheckCollisionPointRec(mousePos, startButton);
        bool areOverlappingProfileSetting = Raylib.CheckCollisionPointRec(mousePos, profileButton);
        bool areOverlappingSettings = Raylib.CheckCollisionPointRec(mousePos, settingButton);
        bool areOverlappingAbout = Raylib.CheckCollisionPointRec(mousePos, aboutButton);

        bool areOverlappingExit = Raylib.CheckCollisionPointRec(mousePos, exitButton);
        bool areOverlappingProfile = Raylib.CheckCollisionPointRec(mousePos, profile);

        bool areOverlappingFacebook = Raylib.CheckCollisionPointRec(mousePos, facebookButton);
        bool areOverlappingTwitter = Raylib.CheckCollisionPointRec(mousePos, twitterButton);
        bool areOverlappingGithub = Raylib.CheckCollisionPointRec(mousePos, githubButton);

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

        Raylib.DrawRectangleRec(StartBlock, pieces.I_CYAN);
        Raylib.DrawRectangleRec(EndBlock, pieces.L_ORANGE);

        Raylib.DrawRectangleRec(startButton, pieces.S_GREEN);
        Raylib.DrawRectangleRec(aboutButton, pieces.J_BLUE);
        Raylib.DrawRectangleRec(profileButton, pieces.T_PURPLE);
        Raylib.DrawRectangleRec(settingButton, pieces.O_YELLOW);

        Raylib.DrawRectangleRec(exitButton, pieces.Z_RED);
        Raylib.DrawRectangleRec(profile, Color.BLACK);

        Raylib.DrawRectangleRec(facebookButton, Color.WHITE);
        Raylib.DrawRectangleRec(twitterButton, Color.WHITE);
        Raylib.DrawRectangleRec(githubButton, Color.WHITE);




        Raylib.DrawText("Home", 10, 10, 40, Color.WHITE);
        Raylib.DrawText("Jing Xu - Te 19B", 1000, 670, 20, Color.WHITE);
        Raylib.DrawText("Welcome To Tetris!", 20, 670, 20, Color.WHITE);
        Raylib.DrawText("Exit!", 10, 80, 30, Color.WHITE);

        Raylib.DrawText("Play!", 400, 205, 40, Color.WHITE);
        Raylib.DrawText("Tetris Time!", 400, 250, 20, Color.WHITE);

        Raylib.DrawText("Profile", 400, 295, 40, Color.WHITE);
        Raylib.DrawText("Change your Profile...", 400, 340, 20, Color.WHITE);

        Raylib.DrawText("Settings", 400, 385, 40, Color.WHITE);
        Raylib.DrawText("Settings...", 400, 430, 20, Color.WHITE);

        Raylib.DrawText("About", 400, 475, 40, Color.WHITE);
        Raylib.DrawText("What the heck is this?", 400, 520, 20, Color.WHITE);



        Raylib.DrawTexture(facebookTexture, 1200, 660, Color.WHITE);
        Raylib.DrawTexture(twitterTexture, 1265, 655, Color.WHITE);
        Raylib.DrawTexture(githubTexture, 1340, 660, Color.WHITE);


        Raylib.DrawTexture(gameImgTextrure, 320, 210, Color.WHITE);
        Raylib.DrawTexture(profileImgTextrure, 320, 300, Color.WHITE);
        Raylib.DrawTexture(settingsImgTextrure, 320, 390, Color.WHITE);
        Raylib.DrawTexture(aboutImgTextrure, 320, 480, Color.WHITE);

        Raylib.DrawRectangleRec(newScreen, Color.WHITE);

        // !Media menyn Btn interaktion
        if (areOverlappingFacebook)
        {

          if (facebookButton.y > 625)
          {
            facebookButton.y -= 4;
          }
          facebookButton.height = 100;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }


        }

        else
        {
          facebookButton.height = 100;

          if (facebookButton.y < 650)
          {
            facebookButton.y += 4;
          }
        }

        if (areOverlappingTwitter)
        {

          if (twitterButton.y > 625)
          {
            twitterButton.y -= 8;
          }
          twitterButton.height = 100;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          twitterButton.height = 100;

          if (twitterButton.y < 650)
          {
            twitterButton.y += 4;
          }
        }

        if (areOverlappingGithub)
        {

          if (githubButton.y > 625)
          {
            githubButton.y -= 4;
          }
          githubButton.height = 100;


          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          githubButton.height = 100;

          if (githubButton.y < 650)
          {
            githubButton.y += 4;
          }
        }

        // !Exit Interaktion
        if (areOverlappingExit)
        {
          if (exitButton.width < 130)
          {
            exitButton.width += 6;
          }


          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          if (exitButton.width > 90)
          {
            exitButton.width -= 6;
          }
        }

        // !Profil
        if (areOverlappingProfile)
        {
          if (profile.y < 10)
          {
            profile.y += 6;
          }
          profile.height = 55;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }
        }

        else
        {
          if (profile.y > 5 && profile.height > 50)
          {
            profile.y -= 6;
            profile.height -= 6;
          }
        }

        // !stora menyn knapp interaktion

        if (areOverlappingAbout)
        {
          if (aboutButton.x > 250)
          {
            aboutButton.x -= 8;
          }
          aboutButton.width = 1400;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          aboutButton.width = 1400;

          if (aboutButton.x < 300)
          {
            aboutButton.x += 8;
          }
        }

        if (areOverlappingProfileSetting)
        {
          if (profileButton.x > 250)
          {
            profileButton.x -= 8;
          }
          profileButton.width = 1400;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          profileButton.width = 1400;

          if (profileButton.x < 300)
          {
            profileButton.x += 8;
          }
        }

        if (areOverlappingSettings)
        {
          if (settingButton.x > 250)
          {
            settingButton.x -= 8;
          }
          settingButton.width = 1400;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }

        }

        else
        {
          settingButton.width = 1400;

          if (settingButton.x < 300)
          {
            settingButton.x += 8;
          }
        }

        if (areOverlappingStart)
        {
          if (startButton.x > 250)
          {
            startButton.x -= 8;
          }
          startButton.width = 1400;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);
            if (newScreen.x < 1000)
            {
              // startButton.x += 16;
              newScreen.x -= 16;
            }
            // game.Game();
          }

        }

        else
        {
          startButton.width = 1400;

          if (startButton.x < 300)
          {
            startButton.x += 8;
          }
        }

        // Raylib.DrawTextEx(f1, "Play!.", new Vector2(450, 205), 40, 0, Color.BLACK);

        Raylib.EndDrawing();
      }
    }
  }
}