using UnityEngine;

public class BulletExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
