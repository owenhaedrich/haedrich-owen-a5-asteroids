using UnityEngine;

public class TeleportingTrail : MonoBehaviour
{
    [SerializeField] private float teleportDistance = 5f;

    TrailRenderer trailRenderer;
    Vector2 position;
    Vector2 previousPosition;

    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        position = transform.position;
        previousPosition = position;
    }

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
