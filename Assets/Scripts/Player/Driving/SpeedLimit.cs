using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedLimit : MonoBehaviour {
    public int speedMax;
    public GameObject gradeSystem;
    private GradeSystem grade;

    private void OnTriggerEnter(Collider other) {
        grade = gradeSystem.GetComponent<GradeSystem>();
        grade.speedMax = speedMax;
        Debug.Log("Speed Limit: " + speedMax);
    }
}

//SetAsLastSibling(): Move the transform to the end of the local transform list. ~ Unity API
