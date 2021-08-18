using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6f);
    }
}