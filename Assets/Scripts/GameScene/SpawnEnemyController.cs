using UnityEngine;

public class SpawnEnemyController : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public float interval = 3f;
    public float startInterval = 1;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), startInterval, interval);
    }

    private void SpawnEnemy()
    {
        float myRan = Random.value;

        if (myRan < 0.2f)
        {
            GameObject g = Instantiate(enemy1, transform.position, Quaternion.identity);
        }
        else if (myRan < 0.4f)
        {
            GameObject g = Instantiate(enemy2, transform.position, Quaternion.identity);
        }
        else
        {
            // Spawn nothing in 60% of the time
        }
    }
}