using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementMethod();
    }

    private void MovementMethod()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);

        _rigidbody.velocity = dir.normalized * speed;
    }
}