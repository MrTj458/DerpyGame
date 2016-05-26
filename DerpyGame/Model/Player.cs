using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DerpyGame.View;


namespace DerpyGame.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;
		private Animation playerAnimation;

		public Animation PlayerAnimaion
		{
			get{ return playerAnimation; }
			set{ playerAnimation = value; }
		}

		public Texture2D PlayerTexture;

		public Vector2 Position;

		public bool Active
		{
			get{ return active; }
			set{ active = value; }
		}
			
		public int Health
		{
			get{ return health; }
			set{ health = value; }
		}
			
		// Get the width of the player ship
		public int Width
		{
			get { return playerAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return playerAnimation.FrameHeight; }
		}

		public int Score
		{
			get{ return score; }
			set{ score = value; }
		}
			
		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture; 
			Position = position;
			this.active = true;
			this.health = 100;
			this.score = 0;
		}

		public void Initialize(Animation animation, Vector2 position)
		{
			playerAnimation = animation;

			// Set the starting position of the player around the middle of the screen and to the back
			Position = position;

			// Set the player to be active
			Active = true;

			// Set the player health
			Health = 100;
		}

		// Draw the player
		public void Draw(SpriteBatch spriteBatch)
		{
			playerAnimation.Draw(spriteBatch);
		}

		// Update the player animation
		public void Update(GameTime gameTime)
		{
			playerAnimation.Position = Position;
			playerAnimation.Update(gameTime);
		}
	}
}

