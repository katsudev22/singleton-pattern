using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace singleton_pattern.EndlessRunner.Objects;

public class Player
{
    public Texture2D Texture;
    public Vector2 Position;
    public Rectangle Bounds;

    private float _gravity;
    
    public Player()
    {
        Texture = new(Globals.GraphicsDevice, 1, 1);
        Texture.SetData([Color.YellowGreen]);
        Position = new(Globals.GameWindow.X / 2, Globals.GameWindow.Y / 2);
        UpdateBounds();
    }
    
    public void Update()
    {
        UpdateBounds();
        Jump();
        ApplyGravity();
    }
    
    public void Draw() =>
        Globals.SpriteBatch.Draw(Texture, Position, Bounds, Color.White, 0f, new(25, 25), 1f, SpriteEffects.None, 0f);

    private void UpdateBounds()
    {
        int width = 50;
        int height = 50;

        Bounds = new Rectangle(
            (int)Position.X - width / 2,
            (int)Position.Y - height / 2,
            width,
            height
        );
    }

    private void Jump()
    {
        if (!InputManager.IsKeyPressed(Keys.Space)) return;
        _gravity = -450f;
    }
    
    private void ApplyGravity()
    {
        _gravity += 800f * Globals.Time;

        float maxGravity = 1200f;
        if (_gravity > maxGravity) _gravity = maxGravity;

        Position.Y += _gravity * Globals.Time;
    }
}