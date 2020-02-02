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

    public GameObject arrow;

    public bool sleeping; //allows ball to move once key has been pressed at start

    private Vector2 dir;

    //saved velocities for pausing at start
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody
        rb = this.GetComponent<Rigidbody2D>();
        //initial velocity
        float angle = Random.Range(0, 1) * 6 + Random.Range(1, 2) * Random.Range(25f, 27f) + Random.Range(0, 4) * 90;
        float radAngle = angle * Mathf.Deg2Rad;
        Debug.Log(angle);
        //save velocity and direction
        dir = new Vector2(Mathf.Cos(radAngle), Mathf.Sin(radAngle));
        velocity = dir * speed;
        rb.Sleep(); //pause the rigidbody at start
        arrow.transform.Rotate(dir, Space.Self);
      
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

    //wakes up the rigid body at start of game
    public void Resume(){
        if (!sleeping)
        {
            rb.WakeUp();
            rb.velocity = velocity;
        }
    }
}

