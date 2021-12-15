using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimit : MonoBehaviour
{
 /* private const float maxSpeedAngle = -20, zeroSpeedAngle = 210;
    public float speedMax;
    private Transform needleTransform, speedLabelTransform;
    public float speed;
    public GameObject vehicle;
    private DrivingController van;

    private void Awake() {
        needleTransform = transform.Find("needle");
        speedLabelTransform = transform.Find("speedLabel");
        speedLabelTransform.gameObject.SetActive(false);
        speed = 0f;
        speedMax = 200f;

        CreateSpeedLabels();
    }

    void Start() {
        van = gameObject.GetComponent<DrivingController>();
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed() {
        bool isPlaying = true;

        while (isPlaying) {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
    }

    private void Update() {
        //Reference DrivingController Script
        speed += 15f * Time.deltaTime;
        if (speed > speedMax) speed = speedMax;

        speed = Mathf.Clamp(speed, 0f, speedMax);

        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }

    private void CreateSpeedLabels() {
        int labelAmount = 6;
        float totalAngleSize = zeroSpeedAngle - maxSpeedAngle;

        for (int i = 0; i <= labelAmount; i++) {
            Transform speedLabelTransform = Instantiate(speedLabelTransform, transform);
            float labelSpeedNormalized = (float)i / labelAmount;
            speedLabelTransform.eulerAngles = new Vector3(0, 0, speedLabelAngle);
            speedLabelTransform.Find("speedText").GetComponent<GradeSystem>() = Mathf.RoundToInt(labelSpeedNormalized * speedMax).ToString();
            speedLabelTransform.Find("speedText").eulerAngles = Vector3.zero;
            speedLabelTransform.gameObject.SetActive(true);
        }

        needleTransform.SetAsLastSibling();
    }

    private float GetSpeedRotation() {
        float totalAngleSize = zeroSpeedAngle - maxSpeedAngle;
        float speedNormalized = speed / speedMax;

        return zeroSpeedAngle - speedNormalized * totalAngleSize;
    }*/
}

//SetAsLastSibling(): Move the transform to the end of the local transform list. ~ Unity API
