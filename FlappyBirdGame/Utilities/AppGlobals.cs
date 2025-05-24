using FlappyBirdGame.Objects;

namespace FlappyBirdGame
{
    public static class AppGlobals
    {
        // Global constants
        public const int FormWidth = 900;
        public const int FormHeight = 600;

        public const int AppVolume = 50; // Default volume level
        public static readonly Character[] Characters = new Character[3]
        {
            new Character("Bird"),
            new Character("Cat"),
            new Character("Dog")
        }; // Character options
        public static GameState gameState = new GameState();
        public static Character SelectedCharacter = Characters[0]; // Default selected character
        public const int fps = 60; // Frames per second for the game loop
        public static readonly float refreshRate = 1000f / fps; // Refresh rate in milliseconds
    }
}