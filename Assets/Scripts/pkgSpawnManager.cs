using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkgSpawnManager : MonoBehaviour {
    public GameObject[] packagePrefabs; //create an array

    /* 
    //Reference Third Person Controller Script:
    private ThirdPersonMovement player
    player = pc.GetComponent<ThirdPersonMovement>(); //we need to reference the player's speed, taken from this script.

    //Speed Reduction Variables (slows down player);
    public float minAmount = , envelopeAmount = , plasticAmount = , sBoxAmount = , mBoxAmount = , lBoxAmount = , maxAmount = ;

    //The customAmount is determined by a random range of weights.
    float customAmount = Random.Range(packagePrefabs[minAmount], packagePrefabs[enevelopeAmount], packagePrefabs[plasticAmount], packagePrefabs[sBoxAmount], packagePrefabs[mBoxAmount], packagePrefabs[lBoxAmount], packagePrefabs[maxAmount]);

     */

    void SpawnRandomPackage() {
        int packageIndex = Random.Range(0, packagePrefabs.Length); //Randomly spawns a package.
    }
}
