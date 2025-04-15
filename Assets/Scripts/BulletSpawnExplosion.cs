using UnityEngine;

public class BulletExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;

    // When a bullet enters a trigger that is an asteroid, we spawn an explosion at the bullet's position.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
    }
}
