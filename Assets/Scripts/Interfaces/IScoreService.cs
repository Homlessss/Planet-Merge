namespace Interfaces
{
    public interface IScoreService
    {
        void AddScore(int level);
        int GetScore();
        int[] GetPlanetCounts();
    }

}