using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    public AudioSource hitBlip;

    public float speed;

    public float incrSpeed; //amount speed increases with every hit

    public ScoreText text;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody
        rb = this.GetComponent<Rigidbody2D>();
        //initial velocity
        //rb.rotation = Random.Range(0, 360);
        //rb.velocity = new Vector2(speed, speed);
        rb.AddForce(new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)) * speed);
        rb.velocity *= speed;

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // play sound
        hitBlip.pitch = (Random.Range(0.5f, 1.5f));
        hitBlip.Play();

        // shake screen
        Camera.main.GetComponent<CameraControl>().Shake(0.4f, 3, 5);

        //increase speed and update velocity accordingly

        speed += incrSpeed;
        rb.AddForce(rb.velocity.normalized * incrSpeed, ForceMode2D.Impulse);

        //update score text
        text.PlusOne();
    }
}

