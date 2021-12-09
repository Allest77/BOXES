using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkgSpawnManager : MonoBehaviour {
    public GameObject[] packagePrefabs; //create a package array
                                        
    //public GameObject[] routePrefabs; //create a route array that can hold a randomized number of stops.
    //public GameObject[] locationsPrefabs; //create an array that holds a randomized number of locations per point of delivery (POD).
    //Multiple Points of Delivery. Locations prefab will hold a random # of packages per POD in a stop. There can sometimes be more than one POD

    void SpawnRandomPackage() {
        //int locationIndex = Random.Range(0, locationPrefab.Length); //Spawn random # of PODs (should be per stop).
        int routeIndex = Random.Range(0, packagePrefabs.Length); //Randomly spawns a package (your current delivery).
    }
}
