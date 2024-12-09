using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    public float thrustForce = 10f; 
    public Vector3 respawnPoint; 

    private Rigidbody2D rb;

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
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
        rb.linearVelocity = Vector2.zero; 
        rb.angularVelocity = 0f;    
    }
}
