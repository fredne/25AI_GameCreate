using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float start_point = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(++start_point, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        start_point -= Time.deltaTime;
        transform.position = new Vector3(start_point, transform.position.y, transform.position.z);

    }
}
