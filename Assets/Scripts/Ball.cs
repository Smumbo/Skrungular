using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public ScreenShake camera;

    public float speed;

    public float incrSpeed; //amount speed increases with every hit

    public int count; //for debugging

    public Text text;

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

        //increase speed and update velocity accordingly
        speed += incrSpeed;
        count++;
        rb.velocity += new Vector2(incrSpeed, incrSpeed);
        //rb.AddForce(dir * speed);
    }
}
