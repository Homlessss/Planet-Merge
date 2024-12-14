using UnityEngine;

namespace Interfaces
{   
    public interface IView
    {
        void UpdateSprite(Sprite sprite, Vector3 scale);
        void ClearSprite();
    }

}