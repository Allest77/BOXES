using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {

    void FixedUpdate() {
        transform.Rotate(0, 0.35f, 0 * Time.deltaTime);
    }
}
