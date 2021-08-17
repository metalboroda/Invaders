using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bullet"))
        {
            // Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>());
        }
    }
}