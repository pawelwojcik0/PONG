using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeft : MonoBehaviour
{
    private Vector3 startposition = new Vector3(-8.5f, 0f, 0f);
    private float maxpositionY = 4f;
    private float movementspeed = 10f;

    private void Start()
    {
        transform.position = startposition;
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= maxpositionY)
        {
            transform.position += Vector3.up * movementspeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y >= -maxpositionY)
        {
            transform.position += Vector3.down * movementspeed * Time.deltaTime;
        }
    }
}
