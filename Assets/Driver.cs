using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpd = 100;

    [SerializeField]
    float moveSpd = 10;

    [SerializeField]
    float unsped = 7;

    [SerializeField]
    float sped = 15;

    void Update()
    {
        float steering =
            Input.GetAxis("Horizontal") * steerSpd * Time.deltaTime;
        float moving = 
            Input.GetAxis("Vertical") * moveSpd * Time.deltaTime;
        transform.Rotate(0, 0, -steering);
        transform.Translate(0, moving, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SPEED")
        {
            moveSpd = sped;
        }
        else if (other.tag == "boop")
        {
            moveSpd = unsped;
        }
    }
}
