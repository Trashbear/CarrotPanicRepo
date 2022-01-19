using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public static int secondsLeft = 12;
    public bool takingAway = false;
    // Start is called before the first frame update
    
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    void FixedUpdate()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(Timertake());
        }
        if (secondsLeft == 0)
        {
            CameraMovement.speed = 0;
        }
    }

    IEnumerator Timertake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
         textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else{
         textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }
}
