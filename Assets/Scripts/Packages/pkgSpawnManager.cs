using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pkgSpawnManager : MonoBehaviour {
    public GameObject[] packagePrefabs; //create a package array
    public Sprite[] uiSprites; //display image of package on the bottom left of ThirdPersonPlayer
    public GameObject[] locationsPrefabs;
    public Image uiImage;
    int routeIndex, minStops = 60, maxStops = 199;
    
    public List<int> stops = new List<int>();

    //stops.Add() - For loop

    void Start() {
        SpawnRandomPackage();

        for (int i = 0; i < Random.Range(minStops, maxStops); i++) {
            stops.Add(60);
        }
    }
                                        
    //Multiple Points of Delivery. Locations prefab will hold a random # of packages per POD in a stop. There can sometimes be more than one POD

    void SpawnRandomPackage() {
        //int locationIndex = Random.Range(0, locationPrefab.Length); //Spawn random # of PODs (should be per stop).
        routeIndex = Random.Range(0, uiSprites.Length); //Randomly spawns a package (your current delivery).
        uiImage.sprite = uiSprites[routeIndex];
    }
}
