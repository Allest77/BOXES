using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, -11.50f);

    void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}

/* GENERAL NOTES
* LateUpdate will move the camera after the vehicle is moved.
* GameObject is a type of variable we are creating. The variable is named player.
* This line makes the camera look for a reference for a GameObject that exists in your project.
* There's a private Vector3 variable named offset. Offset is the camera's position, which needs to be referenced when following the player.
* CONCLUSION - The Main Camera Obj is referencing the Vehicle Obj as the player object, and stores it in our game */

//LATE UPDATE NOTES:
//The camera's position is set to the player's current position.
//You then add a new Vector3 just for this instance.
//CONCLUSION - Offset the camera behind the player by adding the player's position to the camera's position.