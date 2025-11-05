using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public Transform topPipe, bottomPipe, middlePipe;
    public float randomGapOffset = 30f;
    public float spawnRate = 2.0f;
    private float timer = 0f;
    public float distance = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        topPipe = pipe.transform.Find("TopPipe");
        bottomPipe = pipe.transform.Find("BottomPipe");
        middlePipe = pipe.transform.Find("MiddlePipe");
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
        Vector3 pipeGap = new Vector3(0, distance, 0);
        Vector3 deviation = transform.position + new Vector3(0, Random.Range(-randomGapOffset, randomGapOffset), 0);
        topPipe.transform.position = pipeGap;
        bottomPipe.transform.position = -pipeGap;
        middlePipe.transform.localScale = pipeGap*2 + new Vector3(0.75f, 0);
        Instantiate(pipe, deviation, transform.rotation).SetActive(true);
    }
}
