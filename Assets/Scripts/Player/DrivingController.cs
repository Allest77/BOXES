using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingController : MonoBehaviour {
    public float speed = 15.0f, turnSpeed = 18.0f; 
    float horizontalInput, forwardInput;

    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Turn the vehicle.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

//GetAxis is a method (gives values from Input Manager). Horizontal is referenced in Input Manager.
//Strings are given words that a computer will understand. It's known as a string literal???
//transform.Translate is the method. In the method (void), Vector3 is the position, and the position is being multiplied by Time.deltaTime.
//Time.deltaTime is a time constant.
//Time.deltaTime is then being multiplied by the variable, speed, we just declared. In this case, our speed is 5.
//Rotate Method: Vector3.up is y-axis, then we need the angle which is Time.delta * timeSpeed, then * it be turnSpeed.