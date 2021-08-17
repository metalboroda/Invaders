using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ShootBullet), interval, interval);
    }

    private void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}