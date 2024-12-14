using UnityEngine;

namespace MVP.Models
{
    public static class PlanetDatabase
    {
        private static GameObject[] _planetPrefabs;

        public static void Initialize(GameObject[] planetPrefabs)
        {
            _planetPrefabs = planetPrefabs;
        }

        public static GameObject GetPlanetByLevel(int level)
        {
            if (level < 1 || level > _planetPrefabs.Length)
            {
                Debug.LogError("Invalid level requested!");
                return null;
            }
            
            return _planetPrefabs[level - 1];
        }
    }
}