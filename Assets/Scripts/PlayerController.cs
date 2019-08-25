using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //android touch
           /* Vector2 fingerPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if(transform.position.x < fingerPos.x) rb.AddForce(Vector2.right * force, ForceMode2D.Force);
            else rb.AddForce(Vector2.left * force, ForceMode2D.Force);*/
            // PC Check

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        rb.AddForce(Vector2.up*force, ForceMode2D.Impulse);
    }
}
