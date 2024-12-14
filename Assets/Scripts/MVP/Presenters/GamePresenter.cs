using Interfaces;
using MVP.Views;

namespace MVP.Presenters
{
    public  class GamePresenter
    {
        private readonly IScoreService _scoreService;
        private readonly GameView _gameView;

        public GamePresenter(IScoreService scoreService, GameView gameView)
        {
            _scoreService = scoreService;
            _gameView = gameView;
        }

        public void UpdateScore(int level)
        {
            _scoreService.AddScore(level);
            _gameView.UpdateScore(_scoreService.GetScore());
        }

        public void UpdateBestScore(int bestScore)
        {
            _gameView.UpdateBestScore(bestScore);
        }
    }
}