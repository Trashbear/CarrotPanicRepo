using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public GameObject textDisplay;
    public GameObject boxDisplay;

    public static bool winCheck = false;

    public static bool loseCheck = false;

    public AudioClip winSound;

    public AudioClip loseSound;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "";
        boxDisplay.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.scoreValue == 5)
        {
           textDisplay.GetComponent<Text>().text = "You win!";
           boxDisplay.SetActive(true); 

            CameraMovement.speed = 0;
            winCheck = true;
            StartCoroutine(CloseGame());
            audioSource.PlayOneShot(winSound);
        }
        
        if(loseCheck == true)
        {
           textDisplay.GetComponent<Text>().text = "You lose!";
           boxDisplay.SetActive(true);  
           CameraMovement.speed = 0;
           StartCoroutine(CloseGame());
           audioSource.volume = 0.005f;          
           audioSource.PlayOneShot(loseSound);
        }
        if(PlayerController.scoreValue < 5 && TimerCountdown.secondsLeft == 0)
        {
            loseCheck = true;
        }
    }
    IEnumerator CloseGame()
    {
         yield return new WaitForSeconds(2);
         Application.Quit();
    }
}
