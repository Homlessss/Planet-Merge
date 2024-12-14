using Interfaces;
using UnityEngine;

namespace MVP.Presenters
{
    public class SpawnPresenter 
    {
        private readonly ISpawnerService _spawnerService;
        private readonly IInputHandler _inputHandler;
        private readonly IView _spawnView;

        public SpawnPresenter(ISpawnerService spawnerService, IInputHandler inputHandler, IView spawnView)
        {
            _spawnerService = spawnerService;
            _inputHandler = inputHandler;
            _spawnView = spawnView;

            UpdatePreview();
        }

        public void Update()
        {
            if (_inputHandler.IsSpawnRequested(out var position))
            {
                _spawnerService.SpawnObject(position);
            }
        }

        private void UpdatePreview()
        {
            var nextObject = _spawnerService.GetNextObject();
            var spriteRenderer = nextObject.GetComponent<SpriteRenderer>();
            _spawnView.UpdateSprite(spriteRenderer.sprite, spriteRenderer.transform.localScale);
        }
    }
}
