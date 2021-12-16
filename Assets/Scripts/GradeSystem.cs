using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeSystem : MonoBehaviour {
    public Text score;
    public GameObject vehicle;
    private DrivingController van;
    public int drivingScore;
    public int speedMax;

    void Start() {
        van = gameObject.GetComponent<DrivingController>();
        drivingScore = 1000;
        score.text = "score: " + drivingScore;
    }

    void FixedUpdate() {
        if (van.speed > speedMax)
        {
            drivingScore -= 50; //goes down a fixed number depending on the violation.
        }
    }
}
