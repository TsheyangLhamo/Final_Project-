using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float velocityx;
    private float velocityy;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        

    }
    // Update is called once per frame
    void Update()
    {   velocityx = (Input.GetAxis("Horizontal"));
        velocityy = (Input.GetAxis("Vertical"));

        rigidbody2D.velocity = new Vector2(velocityx * speed, velocityy * speed);

        if (velocityx < 0) 
        { 
            transform.localScale = new Vector3(-2, 2, 1); 
        }
        else if (velocityx > 0)
        {
            transform.localScale = new Vector3(2, 2, 1);
        }
    }
}
