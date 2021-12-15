using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pkgSpawnManager : MonoBehaviour {
    public GameObject[] packagePrefabs; //create a package array
    public GameObject[] locationsPrefabs;
    public GameObject player, van;
    public Sprite[] uiSprites; //display image of package on the bottom left of ThirdPersonPlayer
    private ThirdPersonMovement yee;
    private DrivingController drive;
    public Image uiImage;
    public int stopAmount, routeIndex, minStops = 60, maxStops = 199;
    
    public List<int> stops = new List<int>();

    void Start() {
        yee = player.GetComponent<ThirdPersonMovement>();
        drive = van.GetComponent<DrivingController>();
        SpawnRandomPackage();

        stopAmount = Random.Range(minStops, maxStops);
        yee.packageNumber = stopAmount;

        for (int i = 0; i < stopAmount; i++) {
            stops.Add(Random.Range(1, 33)); //NEXT STOP INSTEAD OF RANDOM STOPS, start from 1 - # (between 1 & 200).
        }
    }
                                        
    //Multiple Points of Delivery. Locations prefab will hold a random # of packages per POD in a stop. There can sometimes be more than one POD

    public void SpawnRandomPackage() {
        int locationIndex = Random.Range(0, locationsPrefabs.Length); //Spawn random # of PODs (should be per stop).
        routeIndex = Random.Range(0, uiSprites.Length); //Randomly spawns a package (your current delivery).
        uiImage.sprite = uiSprites[routeIndex];
    }
}
