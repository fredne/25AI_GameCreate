using System.Collections.Generic;
using UnityEngine;

public class Destroy04 : MonoBehaviour
{
    List<GameObject> destroyedObjects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroyedObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroyer Trigger");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Add");
            destroyedObjects.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        if (destroyedObjects.Count > 0)
        {
            foreach (GameObject gameObject in destroyedObjects)
            {
                Debug.Log("destroy");

                //Destroy(gameObject);
            }
        }

        destroyedObjects.Clear();
    }
}
