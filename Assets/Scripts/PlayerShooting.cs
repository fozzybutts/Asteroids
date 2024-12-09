using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject ShrekBulletPrefab;
    public float ShrekBulletSpeed = 10f;
    public Transform ShrekBulletSpawnPoint;
    public AudioSource audioSource;
    public AudioClip fireSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject ShrekBullet = Instantiate(ShrekBulletPrefab, ShrekBulletSpawnPoint.position, ShrekBulletSpawnPoint.rotation);

        Rigidbody2D ShrekBulletRb = ShrekBullet.GetComponent<Rigidbody2D>();
        ShrekBulletRb.linearVelocity = transform.up * ShrekBulletSpeed;

        audioSource.PlayOneShot(fireSound); // Play fire sound
    }
}
