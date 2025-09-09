using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    private float health = 200.0f;
    private float speed = 300.0f;

    private Rigidbody2D rigid;
    public GameObject player;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 direction = player.transform.position - transform.position;

            rigid.linearVelocity =  speed * Time.deltaTime * direction.normalized;
        }

    }
    public void DamageZombie(float damage)
    {
        health -= damage;
        Debug.Log("ױן חמלבט" + health);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}

