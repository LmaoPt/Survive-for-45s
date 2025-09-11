using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RayCast : MonoBehaviour
{
    public Camera cam;
    //public LineRenderer line;
    public ParticleSystem partical;

    private float damagePlayer = 10.0f;

    /*public void Start()
    {
        line = GetComponent<LineRenderer>();

        line.startWidth = 0.1f;
        line.endWidth = 0.1f;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor = Color.yellow;
        line.endColor = Color.red;
    }*/
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

        if (hit.collider != null && Input.GetMouseButton(0))
        {
            partical.Play();
            if (hit.collider.CompareTag("Zombie"))
            {
                ZombieAI zombie = hit.collider.GetComponent<ZombieAI>();
                zombie.DamageZombie(damagePlayer);

            }
            partical.Stop();
        }
    }


    /*public void CreateBuleTrail(Vector3 start, Vector3 end)
    {
        float segmentLength = 0.5f;
        float gapLength = 0.2f;

        // Направление выстрела
        Vector3 direction = (end - start).normalized;
        float totalDistance = Vector3.Distance(start, end);

        List<Vector3> points = new List<Vector3>();
        float currentDistance = 0f;

        while(currentDistance < totalDistance)
        {
            points.Add(start + direction * currentDistance);

            float segmentEnd = Mathf.Min(currentDistance + segmentLength, totalDistance);
            points.Add(start + direction * segmentEnd);

            currentDistance = segmentEnd + gapLength;
        }

        line.positionCount = points.Count;
        line.SetPositions(points.ToArray());

        StartCoroutine(FadeTrail());
    }
    private IEnumerator FadeTrail()
    {
        float duration = 0.3f; // Время исчезновения
        float elapsed = 0f;

        Gradient gradient = new Gradient();
        GradientColorKey[] colorKeys = new GradientColorKey[2];
        GradientAlphaKey[] alphaKeys = new GradientAlphaKey[2];

        colorKeys[0] = new GradientColorKey(Color.yellow, 0f);
        colorKeys[1] = new GradientColorKey(Color.red, 1f);

        while (elapsed < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsed / duration);

            alphaKeys[0] = new GradientAlphaKey(alpha, 0f);
            alphaKeys[1] = new GradientAlphaKey(alpha, 1f);

            gradient.SetKeys(colorKeys, alphaKeys);
            line.colorGradient = gradient;

            elapsed += Time.deltaTime;
            yield return null;
        }

        line.positionCount = 0; // Очищаем точки
    }
    */

}
