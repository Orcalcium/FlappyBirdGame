using FlappyBirdGame.Objects;

namespace FlappyBirdGame
{
    public static class AppGlobals
    {
        // Global constants
        public const int FormWidth = 900;
        public const int FormHeight = 600;
        public static string id = "ㄐㄐ";
        public static int score = 0;
        public static int highestScore = 0;
        public static Image characterImage = Properties.Resources.StupidBird; // Default image for characters
        public static int CharacterSize
        {
            get => _characterSize;
            set
            {
                _characterSize = value;
                // Update all characters' width and height
                foreach (var character in Characters)
                {
                    character.width = value;
                    character.height = value;
                }
                SelectedCharacter.width = value;
                SelectedCharacter.height = value;   
            }
        }
        private static int _characterSize = 30; // Default character size
        public static readonly Character[] Characters = new Character[3]
        {
            new Character(0,0,30,30,"Bird"),
            new Character(0,0,30,30,"Cat"),
            new Character(0,0,30,30,"Dog")
        }; // Character options
        public static GameState GameState = new GameState();
        public static Character SelectedCharacter = Characters[0]; // Default selected character

        public const int fps = 60; // Frames per second for the game loop
        public static readonly float RefreshRate = 1000f / fps; // Refresh rate in milliseconds
    }
}