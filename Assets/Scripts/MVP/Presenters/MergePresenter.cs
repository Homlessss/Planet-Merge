using Interfaces;
using MVP.Views;
using UnityEngine;

namespace MVP.Presenters
{
    public class MergePresenter
    {
        private readonly IMergeService _mergeService;
        private readonly MergeView _mergeView;

        public MergePresenter(IMergeService mergeService, MergeView mergeView)
        {
            _mergeService = mergeService;
            _mergeView = mergeView;
        }

        public void TryMerge(GameObject objectA, GameObject objectB)
        {
            if (_mergeService.CanMerge(objectA, objectB))
            {
                var mergedObject = _mergeService.HandleMerge(objectA, objectB);
                _mergeView.ShowMergeEffect(mergedObject.transform.position);
            }
        }
    }
}