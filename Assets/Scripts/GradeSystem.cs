using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeSystem : MonoBehaviour {
    public Text score;
    public GameObject vehicle;
    public GameObject[] speedLimits;
    private DrivingController van;
    public int drivingScore;
    public int speedMax;

    void Start() {
        van = vehicle.GetComponent<DrivingController>();
        drivingScore = 1000;
        score.text = "score: " + drivingScore;
    }

    void Update() {
        Debug.Log(speedMax);

        if (van.speed > speedMax)
        {
            drivingScore -= 50; //goes down a fixed number depending on the violation.
        }
    }
}
