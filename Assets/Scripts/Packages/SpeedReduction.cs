using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedReduction : MonoBehaviour {
    public GameObject[] packagePrefabs; //create a package array
    private ThirdPersonMovement player; //Reference Third Person Controller Script

    void Start() {
        player = GameObject.Find("ThirdPersonPlayer").GetComponent<ThirdPersonMovement>(); //reference player speed, taken from this script.
    }

    void SpeedReduction() {
        //Speed Reduction Variables (slows down the player's speed. Subtract player's current speed by amount variables);
        public float minAmount = Random.Range(1.1f, 3.0f), envelopeAmount = Random.Range(3.4f, 6.0f), plasticAmount = Random.Range(4.6f, 6.3f), sBoxAmount = Random.Range(2.4f, 12.6f), mBoxAmount = Random.Range(8.0f, 16.8f), lBoxAmount = Random.Range(12.0f, 26.9f), maxAmount = Random.Range(29.0f, 88.1f);
        
        //The customAmount is determined by a random range of weights
        public float customAmount = Random.Range(packagePrefabs[minAmount], packagePrefabs[envelopeAmount], packagePrefabs[plasticAmount], packagePrefabs[sBoxAmount], packagePrefabs[mBoxAmount], packagePrefabs[lBoxAmount], packagePrefabs[maxAmount]);
    } 


    //void Update() {
        //A route variable that holds a random # of packages per stop.
       // int packageIndex = Random.Range(1, 33); //It will never go up to 33.

      //  for (int i = 0; i < packageIndex; i++) {
            
      //  }
}