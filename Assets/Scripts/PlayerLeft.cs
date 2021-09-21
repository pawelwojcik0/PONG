using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeft : MonoBehaviour
{
    [SerializeField] private float movementspeed = 10f;

    private Ball ball;
    private Transform ballTransform;
    private Vector3 startposition = new Vector3(-8.5f, 0f, 0f);

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
        ballTransform = ball.GetComponent<Transform>();
        transform.position = startposition;
    }

    private void Update()
    {
        transform.position = new Vector3(startposition.x, Mathf.Lerp(transform.position.y, ballTransform.transform.position.y, movementspeed), startposition.z);
    }
}
