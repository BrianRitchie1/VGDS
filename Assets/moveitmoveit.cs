using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Handle horizontal movement
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Convert "1" and "0" inputs to -1 and 1 respectively
        if (moveHorizontal == 0f)
        {
            moveHorizontal = Input.GetKey("0") ? 1f : -1f;
        }

        rb.velocity = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y);
    }
}