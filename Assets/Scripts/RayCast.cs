using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera cam;
    void Update()
    {

        Vector2 mousePosition = Input.mousePosition;
        Vector2 vector = cam.ScreenToWorldPoint(mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(vector, Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log("Попал в " + hit.collider.name);
        }
        
        Debug.DrawRay(transform.position, vector, Color.cyan);
    }
}
