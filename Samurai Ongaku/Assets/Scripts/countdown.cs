using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class countdown : MonoBehaviour {
    public Text uiText;
    public float timer;
    
    void Update()
    {
        timer -= Time.deltaTime;

        string seconds = Mathf.Floor(timer % 60).ToString("00");
        string minutes = Mathf.Floor(timer / 60).ToString("0");

        string timerStr = string.Format("{0}:{1}",minutes,seconds);

        uiText.text = "Time\n"+timerStr;

        if (timer <= 1)
        {
            uiText.text = "Game Over";
        }

        if (timer < 0) {

            SceneManager.LoadScene("play_scene");
        }



    }
}
