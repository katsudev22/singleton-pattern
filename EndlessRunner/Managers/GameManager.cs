using Microsoft.Xna.Framework.Input;
using singleton_pattern.EndlessRunner.Objects;

namespace singleton_pattern.EndlessRunner;

public class GameManager
{
    public static GameManager Instance { get; private set; }

    private bool IsGamePaused;
    private Player _player;

    private GameManager()
    {
        IsGamePaused = false;
        _player = new();
    }

    public static void Initialize()
    {
        if (Instance is null) Instance = new();
    }

    public static void Update()
    {
        if (InputManager.IsKeyPressed(Keys.Escape))
            Instance.IsGamePaused = !Instance.IsGamePaused;

        if (Instance.IsGamePaused) return;
        Instance._player.Update();
    }

    public static void Draw()
    {
        Instance._player.Draw();
    }
}