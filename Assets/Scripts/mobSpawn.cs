using UnityEngine;

public class mobSpawn : MonoBehaviour
{
    private float sizeX = 5.0f;
    private float sizeY = 5.0f;
    [SerializeField] GameObject[] ob;
    private float spawnDelay = 3.0f;
    
    private float timer = 0;
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            timer = spawnDelay;
            GameObject currentOb = ob[Random.Range(0, ob.Length - 1)];
            Vector2 sizeSpawn = transform.position + new Vector3(Random.Range(-sizeX, sizeX), Random.Range(-sizeY, sizeY));
            Instantiate(currentOb, new Vector3(sizeSpawn.x, sizeSpawn.y, -10), Quaternion.identity);
        }
    }
}
