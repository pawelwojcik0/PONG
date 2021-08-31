using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector3 startposition = Vector3.zero;

    private void Start()
    {
        startposition = transform.position;

        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(6f, Random.Range(-6f, 6f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("PointColliderRight"))
        {         
            transform.position = startposition;
            GamePlayManager.Instance.LeftPoints += 1;
            rigidbody.velocity = new Vector2(6f, Random.Range(-6f, 6f));
        }

        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("PointColliderLeft"))
        {
            transform.position = startposition;
            GamePlayManager.Instance.RightPoints += 1;
            rigidbody.velocity = new Vector2(-6f, Random.Range(-6f, 6f));
        }

        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Players"))
        {
            rigidbody.velocity = rigidbody.velocity * 1.07f;
        }
    }
}
