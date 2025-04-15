using UnityEngine;
public class BulletParticles : MonoBehaviour
{
    ParticleSystem particleSystem;
    Rigidbody2D rb2d;
    ParticleSystem.VelocityOverLifetimeModule velocityOverLifetimeModule;

    // We use the awake function to connect and prepare our components before the start function
    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        velocityOverLifetimeModule = particleSystem.velocityOverLifetime;
        velocityOverLifetimeModule.enabled = true;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Immediately after the particle system is instantiated, we set the velocity of the particles to be the opposite as the bullet's velocity.
    void Start()
    {
        velocityOverLifetimeModule.x = -rb2d.linearVelocity.x;
        velocityOverLifetimeModule.y = -rb2d.linearVelocity.y;
    }
}
