using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour {
    public GameObject[] playerPrefabs; //create a player array
    public GameObject playerCamera, uiCamera, vehicleCamera;
    public GameObject player, vroom;

    public void Awake() {
      vroom.SetActive(true);
        vehicleCamera.SetActive(true);

      player.SetActive(false);
        playerCamera.SetActive(false);
        uiCamera.SetActive(false);
    }

    void Update()
    {
        //Switch into Human.
        if (Input.GetKey(KeyCode.C)) {
            vroom.SetActive(false);
            vehicleCamera.SetActive(false);
            
            player.SetActive(true);
            playerCamera.SetActive(true);
            uiCamera.SetActive(true);
            player.transform.position = vroom.transform.position;
            Debug.Log("Human");
        }

        //Switch into vehicle.
        if (Input.GetKey(KeyCode.V)) {
            vroom.SetActive(true);
            vehicleCamera.SetActive(true);
            player.transform.position = vroom.transform.position;

            player.SetActive(false);
            playerCamera.SetActive(false);
            uiCamera.SetActive(false);
            Debug.Log("Vehicle");
        }
    }
}
