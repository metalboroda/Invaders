using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBackground : MonoBehaviour
{
    private float scrollSpeed = 6f;

    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * scrollSpeed * Time.deltaTime);
        if (transform.position.y < -24.67852f)
        {
            transform.position = startPos;
        }
    }
}