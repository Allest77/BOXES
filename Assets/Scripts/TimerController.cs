using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour {
    public Text time;
    public float timer = 30;

    private void Update()
    {
        timer -= Time.deltaTime;
        time.text = "" + timer.ToString("f2");
    }

    private void FixedUpdate() {
        if (timer < 0) {
            GameOver(); } }

    void GameOver() {
        SceneManager.LoadScene("GameOver");
        Debug.Log("I Fucked");
    }
}