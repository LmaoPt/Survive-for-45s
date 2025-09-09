using Unity.VisualScripting;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera cam;

    private float damage = 10.0f;
    private void Update()
    {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);


        
        if (hit.collider != null && Input.GetMouseButton(0))
        {

            
            if (hit.collider.CompareTag("Zombie"))
            {
                ZombieAI zombie = hit.collider.GetComponent<ZombieAI>();
                zombie.DamageZombie(damage);
                
            }
        }
    }
}
