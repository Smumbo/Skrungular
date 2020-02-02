using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Esc to Quit
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        //R to restart
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        // activate the game at the beginning
        if (Input.anyKey)
        {
            Time.timeScale = 1;
            arrow.SetActive(false);
        }

    }
}
