using Microsoft.Xna.Framework.Input;
using singleton_pattern.SingletonPattern.Objects;

namespace singleton_pattern.SingletonPattern.Managers;

public class GameManager
{
    private bool IsGamePaused;
    private Player _player;

    public GameManager()
    {
        IsGamePaused = false;
        _player = new();
    }

    public void Update()
    {
        if (InputManager.IsKeyPressed(Keys.Escape))
            IsGamePaused = !IsGamePaused;

        if (IsGamePaused) return;
        _player.Update();
    }

    public void Draw()
    {
        _player.Draw();
    }
}