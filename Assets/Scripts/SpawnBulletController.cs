using System;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1.0f;
    public float delayTime = 0.5f;

    void Start()
    {
        InvokeRepeating(nameof(ShootBullet), delayTime, interval);
    }
    
    private void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        
    }
}