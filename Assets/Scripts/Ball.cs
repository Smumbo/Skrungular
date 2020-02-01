using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

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
        rb.velocity = speed * new Vector2(Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // shake screen
        Camera.main.GetComponent<CameraControl>().Shake(0.5f, 3, 5);

        //increase speed and update velocity accordingly

        speed += incrSpeed;
        rb.velocity += new Vector2(incrSpeed, incrSpeed);

        //update score text
        text.setScoreText();
    }
}

