using UnityEngine;

namespace Interfaces
{
    public interface IInputHandler
    {
        bool IsSpawnRequested(out Vector3 position);
        Vector3 GetPointerPosition();
    }
}