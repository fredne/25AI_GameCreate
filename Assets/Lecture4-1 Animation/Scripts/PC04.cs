using UnityEngine;
using UnityEngine.InputSystem;

public class PC04 : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isJump;
    public float jumpPower = 10.0f;
    public GameObject text;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.SetActive(false);
        animator = GetComponent<Animator>();
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isJump)
        {
            rb.linearVelocity = new Vector2(0.0f, jumpPower);
            isJump = true;
            animator.Play("PlayerJump", -1, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJump = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            text.SetActive(true);
        }
    }
}
