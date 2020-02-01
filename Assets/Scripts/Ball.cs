using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

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
}
