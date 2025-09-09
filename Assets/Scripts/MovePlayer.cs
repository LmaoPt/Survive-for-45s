using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 vectorMove;
    private float speed = 450;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        vectorMove.x = Input.GetAxisRaw("Horizontal");
        vectorMove.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = vectorMove * speed * Time.deltaTime;
    }
    
}
