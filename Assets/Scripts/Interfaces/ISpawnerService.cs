using UnityEngine;

namespace Interfaces
{
    public interface ISpawnerService
    {
            void SpawnObject(Vector3 position);
            GameObject GetNextObject();
            void SelectNextObject();
    }
}