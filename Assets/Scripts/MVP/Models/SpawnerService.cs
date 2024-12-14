using Interfaces;
using UnityEngine;

namespace MVP.Models
{
    public class SpawnerService : ISpawnerService
    {
        private readonly GameObject[] _objectToSpawn;
        private readonly float _spawnHeight = 4.5f;
        private int _nextObjectIndex;

        public SpawnerService(GameObject[] objectToSpawn)
        {
            _objectToSpawn = objectToSpawn;
            SelectNextObject();
        }

        public void SpawnObject(Vector3 position)
        {
            Object.Instantiate(_objectToSpawn[_nextObjectIndex], new Vector3(position.x, _spawnHeight, 0f), Quaternion.identity);
        }

        public GameObject GetNextObject()
        {
            return _objectToSpawn[_nextObjectIndex];
        }

        public void SelectNextObject()
        {
            _nextObjectIndex = Random.Range(0, _objectToSpawn.Length);
        }
    }
}
