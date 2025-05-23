namespace FlappyBirdGame
{
    public class GameState
    {
        private bool isInMainMenu = false;
        private bool IsPause = false;
        private bool isGameOver = false;
        private bool isInGame = false;
        private int score = 0;
        private int highestScore = 0;
        public GameState()
        {
            isInMainMenu = true;
            IsPause = false;
            isGameOver = false;
            isInGame = false;
            score = 0;
            highestScore = 0;
        }
        public void InMainMenu()
        {
            isInMainMenu = true;
            IsPause = false;
            isGameOver = false;
            isInGame = false;
            score = 0;
        }
        public void Pause()
        {
            isInMainMenu = false;
            IsPause = true;
            isGameOver = false;
            isInGame = false;
        }
        public void GameOver()
        {
            UpdateHighstScore();
            isInMainMenu = false;
            IsPause = false;
            isGameOver = true;
            isInGame = false;
        }
        public void InGame()
        {
            isInMainMenu = false;
            IsPause = false;
            isGameOver = false;
            isInGame = true;
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
            return IsPause;
        }
        public bool IsInGame()
        {
            return isInMainMenu;
        }
        public bool IsGameOver()
        {
            return isGameOver;
        }
        
    }
}