using UnityEngine;

public class TeleportingTrail : MonoBehaviour
{
    [SerializeField] private float teleportDistance = 5f;

    TrailRenderer trailRenderer;
    Vector2 position;
    Vector2 previousPosition;

    // Connect to our trail renderer component
    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
    }

    // We check if the distance between the current position and the previous position is greater than the teleport distance.
    // If so, we clear the trail renderer to prevent graphical glitches.
    void Update()
    {
        previousPosition = position;
        position = transform.position;

        if (Vector2.Distance(position, previousPosition) > teleportDistance)
        {
            trailRenderer.Clear();
        }
    }
}
