using UnityEngine;
using Unity.UI;

public class Hpbar : MonoBehaviour
{
    private float hp = 100;
    private float damage = 10;
    public UnityEngine.UI.Image image;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Zombie"))
        {
            hp -= damage;
            image.fillAmount = hp / 100;
        }
    }
}
