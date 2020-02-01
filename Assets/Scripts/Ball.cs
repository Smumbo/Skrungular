using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    public float incrSpeed; //amount speed increases with every hit

    public int count; //for debugging

    public GameObject northWall;
    public GameObject southWall;
    public GameObject eastWall;
    public GameObject westWall;

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

    /*    Vector2 dir = this.transform.position;
        if (collision.gameObject == eastWall || collision.gameObject == westWall)
        {
            dir.x *= -1;
        }
        else if (collision.gameObject == northWall || collision.gameObject == southWall){
            dir.y *= -1;
        }*/

        //increase speed and update velocity accordingly
        speed += incrSpeed;
        count++;
        rb.velocity += new Vector2(incrSpeed, incrSpeed);
        //rb.AddForce(dir * speed);
    }
}
