using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    public float incrSpeed; //amount speed increases with every hit

    public int count; //for debugging

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody
        rb = this.GetComponent<Rigidbody2D>();
        //initial velocity
        rb.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private float hitFactorX(Vector2 ballPos, Vector2 wallPos, float wallLength){
        return (ballPos.x - wallPos.x) / wallLength;
    }

    private float hitFactorY(Vector2 ballPos, Vector2 wallPos, float wallLength){
        return (ballPos.y - wallPos.y) / wallLength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Hit wall
        float x = hitFactorX(transform.position, 
                             collision.transform.position, 
                             collision.collider.bounds.size.x);
        float y = hitFactorY(transform.position,
                             collision.transform.position,
                             collision.collider.bounds.size.y);
        Vector2 dir = new Vector2(x, y).normalized;
        //increase speed and update velocity accordingly
        speed += incrSpeed;
        count++;
        rb.velocity = dir * speed;
    }
}
