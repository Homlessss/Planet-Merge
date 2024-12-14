using Interfaces;

namespace MVP.Models
{
    public class ScoreService : IScoreService
    {
        private int _currentScore;
        private readonly int[] _planetCounts;

        public ScoreService(int maxLevel)
        {
            _planetCounts = new int[maxLevel +1];
        }

        public void AddScore(int level)
        {
            _planetCounts[level]++;
            _currentScore += level;
        }

        public int GetScore()
        {
            return _currentScore;
        }

        public int[] GetPlanetCounts()
        {
            return _planetCounts;
        }
    }
}