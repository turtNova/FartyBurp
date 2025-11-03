using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffset = 10f;
    public float spawnRate = 2.0f;
    private float timer = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        Vector3 deviation = transform.position + new Vector3(0, Random.Range(-heightOffset, heightOffset), 0);
        Instantiate(pipe, deviation, transform.rotation);
    }
}
