using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minSpeed = 1f;  
    public float maxSpeed = 5f;  
    public float maxRotationSpeed = 200f;  

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float speed = Random.Range(minSpeed, maxSpeed);
        rb.linearVelocity = transform.up * speed;

        float rotationSpeed = Random.Range(-maxRotationSpeed, maxRotationSpeed);
        rb.angularVelocity = rotationSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);  
            Destroy(gameObject);  
        }
    }
}
