using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject tr;
    private Rigidbody2D rb;
    private float speed = 200f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = tr.transform.position * Time.deltaTime * speed;
    }
}
