using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBounds : MonoBehaviour
{

    public GameObject restart;

    public AudioSource loseSound;

    public bool slowDown; 

    // Start is called before the first frame update
    void Start()
    {
        restart.SetActive(false);
        slowDown = false;
        loseSound = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        restart.SetActive(true);
        slowDown = true;
        loseSound.Play();
    }
}
