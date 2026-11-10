using Raylib_cs;
using System.Numerics;

namespace GameClient
{
    static class Program
    {
        public static int screenWidth = 1920;
        public static int screenHeight = 1080;

        [System.STAThread]
        public static void Main()
        {
            Vector2 ballPos = new(screenWidth / 2, screenHeight / 2);

            Raylib.InitWindow(screenWidth, screenHeight, "Hello, World");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.W)) ballPos.Y -= 200.0f * Raylib.GetFrameTime();
                if (Raylib.IsKeyDown(KeyboardKey.A)) ballPos.X -= 200.0f * Raylib.GetFrameTime();
                if (Raylib.IsKeyDown(KeyboardKey.S)) ballPos.Y += 200.0f * Raylib.GetFrameTime();
                if (Raylib.IsKeyDown(KeyboardKey.D)) ballPos.X += 200.0f * Raylib.GetFrameTime();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RayWhite);
                Raylib.DrawCircleV(ballPos, 100, Color.Blue);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
