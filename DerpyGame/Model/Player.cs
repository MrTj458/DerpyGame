using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace DerpyGame.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;

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
			
		public int Width
		{
			get { return PlayerTexture.Width; }
		}
			
		public int Height
		{
			get { return PlayerTexture.Height; }
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

		public void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

		public void Update()
		{

		}
	}
}

