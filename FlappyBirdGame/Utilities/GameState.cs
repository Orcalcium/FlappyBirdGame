namespace FlappyBirdGame
{
    public class GameState
    {
        GameStateEnum stateEnum= GameStateEnum.MainMenu;
        private int score;
        private int highestScore;
        public enum GameStateEnum
        {
            MainMenu,
            InGame,
            Pause,
            GameOver
        }
        public GameState()
        {
            stateEnum = GameStateEnum.MainMenu;
            score = 0;
            highestScore = 0;
        }
        public void InMainMenu()
        {
            stateEnum=GameStateEnum.MainMenu;
            score = 0;
        }
        public void Pause()
        {
            stateEnum=GameStateEnum.Pause;
        }
        public void GameOver()
        {
            UpdateHighstScore();
            stateEnum=GameStateEnum.GameOver;
        }
        public void InGame()
        {
            stateEnum=GameStateEnum.InGame;
        }
        public void UpdateHighstScore()
        {
            if (score > highestScore)
            {
                highestScore = score;
            }
        }
        public void UpdateScore(int score)
        {
            this.score = score;
        }

        public bool IsPaused()
        {
            return stateEnum==GameStateEnum.Pause;
        }
        public bool IsInGame()
        {
            return stateEnum == GameStateEnum.InGame;
        }
        public bool IsGameOver()
        {
            return stateEnum == GameStateEnum.GameOver;
        }
        public bool IsInMainMenu()
        {
            return stateEnum == GameStateEnum.MainMenu;
        }
        public int GetScore()
        {
            return score;
        }
        public int GetHighestScore()
        {
            return highestScore;
        }

    }
}