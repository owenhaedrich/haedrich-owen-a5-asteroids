using UnityEngine;
public class BulletParticles : MonoBehaviour
{
    ParticleSystem particleSystem;
    Rigidbody2D rb2d;
    ParticleSystem.VelocityOverLifetimeModule velocityOverLifetimeModule;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        velocityOverLifetimeModule = particleSystem.velocityOverLifetime;
        velocityOverLifetimeModule.enabled = true;
        rb2d = GetComponent<Rigidbody2D>();
        velocityOverLifetimeModule.x = -rb2d.linearVelocity.x;
        velocityOverLifetimeModule.y = -rb2d.linearVelocity.y;
    }
}
