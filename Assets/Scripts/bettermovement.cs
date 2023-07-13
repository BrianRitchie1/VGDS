using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bettermovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    public static bool isUpPressed = true;

    public static bool isFacingRight = true;

    public static int health;

    public int maxHealth;
    public int iFrames = 40;
    public static bool isAlive = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;

    public Text gameOverScreen;
    private int respawnTimer = 300;

    void Start()
    {
        health = maxHealth;
        isAlive = true;
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && iFrames <= 0)
        {
            health -= 1;
            iFrames = 40;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            isAlive = false;

            gameOverScreen.text = "Game Over\n\nYou Suck\n\nScore: " + UIScript.score;


        }
    }    

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded () && isAlive)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonDown("Jump") && IsWalled () && isAlive)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f && isAlive)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();


        if (!isAlive)
        {
            respawnTimer --;
            if (respawnTimer <= 0)
            {
                SceneManager.LoadScene(0);
                UIScript.score *= 0;

            }
        }
        
    }

    private void FixedUpdate()
    {
        if (isAlive)
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
            iFrames --;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private bool IsWalled()
    {
        return Physics2D.OverlapCircle(wallCheck.position, 0.8f, wallLayer);
    }

    private void Flip()
    {
        if ((isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) && isAlive)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}