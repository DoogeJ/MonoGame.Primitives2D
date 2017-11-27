using System;
using MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sample
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            //DrawRectangle Examples
            spriteBatch.DrawRectangle(new Rectangle(100, 100, 100, 200), Color.Purple, 20);

            spriteBatch.DrawRectangle(new Rectangle(10, 10, 100, 200), Color.Yellow, 2);
            spriteBatch.DrawRectangle(new Rectangle(20, 20, 100, 200), Color.Yellow, 1);
            spriteBatch.DrawRectangle(new Vector2(30, 30), new Vector2(100, 200), Color.Yellow);
            spriteBatch.DrawRectangle(new Vector2(40, 40), new Vector2(100, 200), Color.Yellow, 5);

            //DrawCircle Examples
            spriteBatch.DrawCircle(400, 100, 90, 3, Color.White * 0.2f);
            spriteBatch.DrawCircle(400, 100, 90, 4, Color.White * 0.3f);
            spriteBatch.DrawCircle(400, 100, 90, 5, Color.White * 0.4f);
            spriteBatch.DrawCircle(400, 100, 90, 6, Color.White * 0.5f);
            spriteBatch.DrawCircle(400, 100, 90, 7, Color.White * 0.6f);
            spriteBatch.DrawCircle(400, 100, 90, 8, Color.White * 0.7f);
            spriteBatch.DrawCircle(400, 100, 90, 9, Color.White * 0.8f);
            spriteBatch.DrawCircle(400, 100, 90, 10, Color.White * 0.9f);
            spriteBatch.DrawCircle(400, 100, 90, 20, Color.Red);

            spriteBatch.DrawCircle(600, 100, 100, 50, Color.Green, 10);
            spriteBatch.DrawCircle(new Vector2(600, 100), 40, 30, Color.Green, 30);

            //FillRectangle Examples
            spriteBatch.FillRectangle(350, 340, 100, 100, Color.Red * 0.4f);
            spriteBatch.FillRectangle(new Rectangle(350, 340, 100, 100), Color.Red * 0.3f, (float)Math.PI / 4f);
            spriteBatch.FillRectangle(new Vector2(350, 340), new Vector2(100, 100), Color.Red * 0.2f, (float)Math.PI / 3f);
            spriteBatch.FillRectangle(350, 340, 100, 100, Color.Red * 0.5f, (float)Math.PI);

            //DrawArc Examples
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(180), Color.Navy, 1);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(160), Color.Navy * 0.9f, 2);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(140), Color.Navy * 0.8f, 4);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(120), Color.Navy * 0.7f, 6);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(90), Color.Navy * 0.6f, 8);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(80), Color.Navy * 0.5f, 10);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(65), Color.Navy * 0.4f, 12);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(45), Color.Navy * 0.3f, 14);
            spriteBatch.DrawArc(new Vector2(600, 350), 100, 180, MathHelper.ToRadians(180), MathHelper.ToRadians(12), Color.Navy * 0.2f, 16);

            spriteBatch.DrawArc(new Vector2(600, 400), 80, 90, MathHelper.ToRadians(90), MathHelper.ToRadians(220), Color.Navy, 10);

            //DrawLine Examples
            spriteBatch.DrawLine(new Vector2(420, 220), new Vector2(480,280), Color.Orange);
            spriteBatch.DrawLine(new Vector2(420, 230), new Vector2(480, 290), Color.Orange, 2);
            spriteBatch.DrawLine(new Vector2(420, 240), new Vector2(480, 300), Color.Orange, 5);
            spriteBatch.DrawLine(new Vector2(420, 255), new Vector2(480, 315), Color.Orange, 10);

            spriteBatch.DrawLine(new Vector2(100, 400), 40.0f, MathHelper.ToRadians(270), Color.Green, 3);
            spriteBatch.DrawLine(new Vector2(103, 400), 40.0f, MathHelper.ToRadians(105), Color.Blue, 3);
            spriteBatch.DrawLine(new Vector2(101, 400), 40.0f, MathHelper.ToRadians(0), Color.Red, 3);

            //PutPixel Examples
            spriteBatch.PutPixel(new Vector2(250, 150), Color.Red);
            spriteBatch.PutPixel(new Vector2(251, 150), Color.Red);
            spriteBatch.PutPixel(new Vector2(251, 151), Color.Red);
            spriteBatch.PutPixel(new Vector2(250, 151), Color.Red);

            spriteBatch.PutPixel(new Vector2(253, 150), Color.Red);
            spriteBatch.PutPixel(new Vector2(254, 150), Color.Red);
            spriteBatch.PutPixel(new Vector2(254, 151), Color.Red);
            spriteBatch.PutPixel(new Vector2(253, 151), Color.Red);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
