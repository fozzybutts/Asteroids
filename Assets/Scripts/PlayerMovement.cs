using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    public float thrustForce = 10f; 

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
        float rotationInput = Input.GetAxis("Horizontal");
        rb.rotation -= rotationInput * rotationSpeed * Time.deltaTime;

        
        float thrustInput = Input.GetAxis("Vertical");
        Vector2 thrust = transform.up * thrustInput * thrustForce;
        rb.AddForce(thrust);
    }
}