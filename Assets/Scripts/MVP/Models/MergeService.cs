using Interfaces;
using UnityEngine;

namespace MVP.Models
{
    public class MergeService : IMergeService
    {
        public GameObject HandleMerge(GameObject objectA, GameObject objectB)
        {
            if (!CanMerge(objectA, objectB)) return null;
            
            var newLevel = objectA.GetComponent<Planet>().Level + 1;
            var newPlanetPrefab = PlanetDatabase.GetPlanetByLevel(newLevel);
            
            var mergedPosition = (objectA.transform.position + objectB.transform.position) / 2;
            
            Object.Destroy(objectA);
            Object.Destroy(objectB);
            return Object.Instantiate(newPlanetPrefab, mergedPosition, Quaternion.identity);
        }

        public bool CanMerge(GameObject objectA, GameObject objectB)
        {
            var levelA = objectA.GetComponent<Planet>().Level;
            var levelB = objectB.GetComponent<Planet>().Level;
            return levelA == levelB;
        }
    }
    
}