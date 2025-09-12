using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    private float MaxHp = 500;
    private float currentHp;
    

    public Image image;
    public void Start()
    {
        currentHp = MaxHp;
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Zombie"))
        {
            ZombieAI zombie = collision.gameObject.GetComponent<ZombieAI>();

            currentHp -= zombie.damageZombie;
            image.fillAmount = currentHp / MaxHp;
        }

    }
    
}
     