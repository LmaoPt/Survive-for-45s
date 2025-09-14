using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera cam;
    private float damagePlayer = 10.0f;
    public Transform pistol;

    public ParticleSystem particle;

    private void Awake()
    {
        pistol = transform.Find("Aim");
    }
    private void Update()
    {
        Shot();

        MoveWeapon();
    }
    public void Shot()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
        if (Input.GetMouseButtonDown(0))
        {
            particle.Play();

            if (hit.collider != null)
            {

                if (hit.collider.CompareTag("Zombie"))
                {
                    ZombieAI zombie = hit.collider.GetComponent<ZombieAI>();
                    zombie.DamageZombie(damagePlayer);

                }
            }
        }

    }
    public void MoveWeapon()
    {
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mousePosition - transform.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        pistol.eulerAngles = new Vector3 (0, 0, angle);
    }




}
