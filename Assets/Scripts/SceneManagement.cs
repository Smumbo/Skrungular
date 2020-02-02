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

    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        pauseText.SetActive(true);
        ball.sleeping = true;
        paused = true;
    }

    // Update is called once per frame
    void Update()
    {
        // activate the game at the beginning
        if (paused)
        {

            if (Input.anyKey && !(Input.GetKey(KeyCode.R)))
            {
                Time.timeScale = 1;
                pauseText.SetActive(false);
                paused = false;
                arrow.SetActive(false);
                ball.sleeping = false;
                ball.Resume();
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
            if (Time.timeScale > 0)
            {

                Time.timeScale /= 1.2f;
            }
        }


    }
}
