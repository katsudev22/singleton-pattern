# singleton-pattern
my study of the **singleton pattern** for games, using **monogame** for main loop and rendering things.

the pattern consists of having elements with a single instance that provides methods easily accessible to the code. in this example project, I applied this when creating the InputManager.cs source file.

using this pattern here allows centralizing input processing and global game states, making them accessible from any entity without passing heavy references through every constructor.

it can also be applied in other contexts, such as with an AudioManager, UIManager or SaveManager.

<img width="647" height="138" alt="image" src="https://github.com/user-attachments/assets/7e0b3d86-0234-4685-8c9d-5cedb6de69a2" />

# considerations
while singletons provide convenient global access, they should be used with caution:   
**global state:** can hide dependencies between classes and make debugging harder<br>
**testing:** static references make unit testing more complex<br>

# references
https://gameprogrammingpatterns.com/singleton.html<br>
https://en.wikipedia.org/wiki/Singleton_pattern

# project
<img width="1357" height="787" alt="image" src="https://github.com/user-attachments/assets/b9203033-8822-4dc5-aa31-7c8e4db2fff3" />

## controls
<kbd>escape</kbd> -> pause the game<br>
<kbd>space</kbd> -> jump

## how to run
```bash
git clone https://github.com/katsudev22/singleton-pattern.git
cd singleton-pattern
dotnet run
```
<sub>*(make sure you have requirements for run monogame and dotnet!!)*</sub>
