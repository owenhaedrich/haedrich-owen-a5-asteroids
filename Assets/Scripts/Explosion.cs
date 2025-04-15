using UnityEngine;

public class Explosion : MonoBehaviour
{
    float lifetime = 0.5f; // Lifetime of the explosion effect
    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject); // Destroy the explosion effect after its lifetime
        }
    }
}
