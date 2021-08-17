using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemyBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Bullet"))
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);
            if (!collision.gameObject.CompareTag("Wall"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
