using UnityEditor.U2D.Aseprite;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Spike : MonoBehaviour
{
    private Vector3 startPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - Time.deltaTime * 10, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

        if(collision.gameObject.CompareTag("SpikeDestroyer"))
        {
           // Destroy(gameObject);
        }
    }

}
