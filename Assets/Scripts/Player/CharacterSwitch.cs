using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour {
    public GameObject[] playerPrefabs; //create a player array
/*
    public void Awake() {
      vroom.SetActive(true);
      player.SetActive(false);
    }

    void Start() {
        player = GameObject.Find("ThirdPersonPlayer").GetComponent<ThirdPersonMovement>(); //reference player speed, taken from this script.
        vroom = GameObject.Find("VROOM").GetComponent<DrivingController>(); //reference to driving
    }

    void Switch() {
        int playerIndex = (0, packagePrefabs.Length);
    }

    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) {
            vroom.SetActive(false);
            player.SetActive(true);
        }
    } */
}
