using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minSpeed = 1f;  
    public float maxSpeed = 5f;  
    public float maxRotationSpeed = 200f;  
    public int health = 3; 
    public AudioClip explosionSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>(); 

        float speed = Random.Range(minSpeed, maxSpeed);
        rb.linearVelocity = transform.up * speed;

        float rotationSpeed = Random.Range(-maxRotationSpeed, maxRotationSpeed);
        rb.angularVelocity = rotationSpeed;

        if (audioSource.playOnAwake)
        {
            audioSource.playOnAwake = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);  
            TakeDamage(1); 
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            PlayExplosionSound();
            Destroy(gameObject); 
        }
    }

    void PlayExplosionSound()
    {
        GameObject explosion = new GameObject("Explosion");
        AudioSource explosionSource = explosion.AddComponent<AudioSource>();
        explosionSource.clip = explosionSound;
        explosionSource.Play();

        Destroy(explosion, explosionSound.length); 
    }
}
