using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour {
    public GameObject[] playerPrefabs; //create a player array

    public void Awake() {
        vroom.SetActive(true);
        player.SetActive(false);
    }

    void Switch() {
        int playerIndex = (0, packagePrefabs.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) {
            vroom.SetActive(false);
            player.SetActive(true);
        }
    }
}
