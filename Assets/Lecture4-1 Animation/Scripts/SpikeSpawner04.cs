using UnityEngine;

public class SpikeSpawner04 : MonoBehaviour
{
    float spawnTimer = 0.0f;
    float ct = 0.0f;
    public GameObject SpikePrefab;
    public float spawnMinTime = 2.0f;
    public float spawnMaxTime = 4.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = Random.Range(spawnMinTime, spawnMaxTime);

    }

    // Update is called once per frame
    void Update()
    {
        ct += Time.deltaTime;

        if (ct >= spawnTimer)
        {
            ct -= spawnTimer;
            spawnTimer = Random.Range(spawnMinTime, spawnMaxTime);
            SpikePrefab.transform.rotation = transform.rotation;
            Vector3 pos = transform.position;
            SpikePrefab.transform.position = pos;
            Instantiate(SpikePrefab);

        }
    }
}
