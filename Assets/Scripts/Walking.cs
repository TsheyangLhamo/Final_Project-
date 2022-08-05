using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private float Pspeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

        

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // Left movement
        {
            transform.Translate(Pspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Right movement
        {
            transform.Translate(Pspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);

        }
    }
}
