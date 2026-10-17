using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using singleton_pattern.EndlessRunner;

namespace singleton_pattern;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _graphics.PreferredBackBufferWidth = Globals.GameWindow.X;
        _graphics.PreferredBackBufferHeight = Globals.GameWindow.Y;
        _graphics.ApplyChanges();
        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        Globals.GraphicsDevice = GraphicsDevice;
        Globals.SpriteBatch = new SpriteBatch(Globals.GraphicsDevice);
        Globals.ContentManager = Content;
        
        GameManager.Initialize();
        InputManager.Initialize();
    }

    protected override void Update(GameTime gameTime)
    {
        Globals.Update(gameTime);
        GameManager.Update();
        InputManager.Update();
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.AntiqueWhite);

        Globals.SpriteBatch.Begin();
        GameManager.Draw();
        Globals.SpriteBatch.End();
        
        base.Draw(gameTime);
    }
}
