using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PlatformerMonogame1
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player = new Player(); // Creates an instance of the Player class.

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player.Load(Content); // Call the 'Load' function in the Player class.
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            player.Update(deltaTime); // Call 'Update' from the Player class.

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // Clears anything previously drawn to the screen.
            GraphicsDevice.Clear(Color.Gray);
            // Begin drawing.
            spriteBatch.Begin();
            // Call the 'Draw' Function from the Player class.
            player.Draw(spriteBatch);
            // Finish drawing
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
