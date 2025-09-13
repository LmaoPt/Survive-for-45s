using UnityEngine;

public class SmoothTracking : MonoBehaviour
{
    public Transform player;
    private Vector3 target;

    private float TrackingSpeed = 3f;

    private void FixedUpdate()
    {
        Vector3 currentPosition = Vector3.Lerp(transform.position, target, TrackingSpeed * Time.deltaTime);
        transform.position = currentPosition;

        target = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
