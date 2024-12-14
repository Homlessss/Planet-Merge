using UnityEngine;

namespace MVP.Views
{
    public class GameView :MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI scoreText;
        [SerializeField] private TMPro.TextMeshProUGUI bestScoreText;

        public void UpdateScore(int score)
        {
            scoreText.text = "Score: " + score;
        }

        public void UpdateBestScore(int bestScore)
        {
            bestScoreText.text = "Best: " + bestScore;
        }
    }
}