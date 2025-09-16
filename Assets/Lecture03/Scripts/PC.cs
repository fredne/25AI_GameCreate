using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping;
    public float jumpPower = 10.0f;

    public GameObject text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && !isJumping)
        {
            rb.linearVelocity = new Vector2(0.0f, jumpPower);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isJumping && collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            text.SetActive(true);
        }
    }
}
