using Interfaces;
using UnityEngine;

namespace MVP.Views
{
    public class SpawnView : MonoBehaviour, IView
    {
        [SerializeField] private SpriteRenderer previewSpriteRenderer;

        public void UpdateSprite(Sprite sprite, Vector3 scale)
        {
            previewSpriteRenderer.sprite = sprite;
            previewSpriteRenderer.transform.localScale = scale;
        }

        public void ClearSprite()
        {
            previewSpriteRenderer.sprite = null;
        }
    }
}
