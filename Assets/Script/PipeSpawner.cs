using UnityEngine;

public class PipeSpawner : MonoBehaviour
{   
    public GameObject pipePrefab;
    public float spawnRate = 2;
    public float pipeHeightOffset = 10;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();         
        
    }

    // Update is called once per frame
    void Update()
    {   
         if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }else
        {
            SpawnPipe();
            timer = 0;  
        }
    }
    void SpawnPipe()
    {   
        float lowestPoint = transform.position.y - pipeHeightOffset;
        float highestPoint = transform.position.y + pipeHeightOffset;
        
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}