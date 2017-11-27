using System;
using System.Collections.Generic;
using System.Linq;
using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Primitives2DSample
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			// Allows the game to exit
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
				this.Exit();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			spriteBatch.Begin();

			spriteBatch.DrawRectangle(new Rectangle(100, 100, 100, 200), Color.Purple, 20);

			spriteBatch.DrawRectangle(new Rectangle(10, 10, 100, 200), Color.Yellow, 2);
			spriteBatch.DrawRectangle(new Rectangle(20, 20, 100, 200), Color.Yellow, 1);
			spriteBatch.DrawRectangle(new Vector2(30, 30), new Vector2(100, 200), Color.Yellow);
			spriteBatch.DrawRectangle(new Vector2(40, 40), new Vector2(100, 200), Color.Yellow, 5);

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

			spriteBatch.FillRectangle(350, 340, 100, 100, Color.Red * 0.4f);
			spriteBatch.FillRectangle(new Rectangle(350, 340, 100, 100), Color.Red * 0.3f, (float)Math.PI / 4f);
			spriteBatch.FillRectangle(new Vector2(350, 340), new Vector2(100, 100), Color.Red * 0.2f, (float)Math.PI / 3f);
			spriteBatch.FillRectangle(350, 340, 100, 100, Color.Red * 0.5f, (float)Math.PI);

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

			base.Draw(gameTime);
			spriteBatch.End();
		}
	}
}
