using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    public GameObject arrow;

    public Ball ball;

    public GameObject pauseText;

    public LoseBounds lose;

    public AudioSource Music;

    private AudioSource startSound;

    public ScoreText score;

    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        pauseText.SetActive(true);
        ball.sleeping = true;
        paused = true;
        startSound = this.GetComponent<AudioSource>();
        Music.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        // activate the game at the beginning
        if (paused)
        {

            if (Input.anyKey && !(Input.GetKey(KeyCode.R)))
            {
                //reset time scale
                Time.timeScale = 1;
                //disable starting text and arrow
                pauseText.SetActive(false);
                paused = false;
                arrow.SetActive(false);
                //move ball
                ball.sleeping = false;
                ball.Resume();
                //play audio
                startSound.Play();
                Music.Play();
            }
        }
        else
        {
            //R to restart
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }

        //Esc to Quit
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //slow time scale on lose condition
        if (lose.slowDown)
        {
            Music.Pause();
            score.stopShaking = true;
            if (Time.timeScale > 0)
            {

                Time.timeScale /= 1.2f;
            }
        }


    }
}
