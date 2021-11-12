using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonDash : MonoBehaviour
{

}
    /*ThirdPersonMovement moveScript;
    public float dashSpeed, dashTime;

    void Start() {
        moveScript = GetComponent<ThirdPersonMovement>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash() {
        float startTime = Time.time;

        while(Time.time < startTime + dashTime) {
            moveScript.controller.Move(moveScript.controller * dashSpeed * Time.deltaTime);

            yield return null;
        }
    }
} */