using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject SpikePrefab;
    public float spawnTimer = 0.0f;
    public float ct = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = Random.Range(4.0f, 8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        ct += Time.deltaTime;

        if (ct >= spawnTimer)
        {
            ct -= spawnTimer;
            spawnTimer = Random.Range(2.0f, 4.0f);
            GameObject spike = Instantiate(SpikePrefab);
            spike.transform.position = transform.position;
        }

    }

}
