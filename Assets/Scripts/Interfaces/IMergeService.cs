using UnityEngine;

namespace Interfaces
{
    public interface IMergeService
    {
        GameObject HandleMerge(GameObject objectA, GameObject objectB);
        bool CanMerge(GameObject objectA, GameObject objectB);
    }
}