using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    public float thrustForce = 10f; 
    public Vector3 respawnPoint; 
    public AudioSource audioSource;
    public AudioClip engineSound;
    public AudioClip explosionSound; 

    private Rigidbody2D rb;
    private bool isThrusting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position; 
    }

    void Update()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        rb.rotation -= rotationInput * rotationSpeed * Time.deltaTime;

        float thrustInput = Input.GetAxis("Vertical");
        Vector2 thrust = transform.up * thrustInput * thrustForce;
        rb.AddForce(thrust);

        if (thrustInput != 0 && !isThrusting)
        {
            audioSource.PlayOneShot(engineSound);
            isThrusting = true;
        }
        else if (thrustInput == 0)
        {
            isThrusting = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            DestroyAsteroidAndRespawnPlayer(collision.gameObject);
        }
    }

    void DestroyAsteroidAndRespawnPlayer(GameObject asteroid)
    {
        GameObject explosion = new GameObject("Explosion");
        AudioSource explosionSource = explosion.AddComponent<AudioSource>();
        explosionSource.clip = explosionSound;
        explosionSource.Play();
        Destroy(explosion, explosionSound.length); 
        Destroy(asteroid); 
        Respawn(); 
    }

    void Respawn()
    {
        transform.position = respawnPoint;
        rb.linearVelocity = Vector2.zero; 
        rb.angularVelocity = 0f; 
    }
}
