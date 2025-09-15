using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject SpikePrefab;
    bool a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            GameObject spike = Instantiate(SpikePrefab);
            spike.transform.position = transform.position;
            a = false;
        }
    }

}
