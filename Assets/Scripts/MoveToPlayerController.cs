using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        BulletToPlayerPosition();
    }

    private void BulletToPlayerPosition()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        // Vector3 v3 = (gameObject.transform.position - transform.position).normalized;
        // Vector2 v2 = new Vector2(v3.x, v3.y);
        if (gameObject != null)
        {
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;
        }
    }
}