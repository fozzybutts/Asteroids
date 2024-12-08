using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public GameObject Asteroids;
    public GameObject Player;
    public float resetPositionXLeft = -30.0f;
    public float resetPositionXRight = 30.0f;
    public float resetPositionYUp = 5.0f;
    public float resetPositionYDown = -5.0f;



    void Start()
    {
        
    }

    void Update()
    {
        if (Player.transform.position.x > resetPositionXRight)
        {
            // Then reset player's position to the LEFT
            Player.transform.position = new Vector3(resetPositionXLeft, Player.transform.position.y, Player.transform.position.z);
        }

        if (Player.transform.position.x < resetPositionXLeft)
        {
            // Then reset player's position to the RIGHT
            Player.transform.position = new Vector3(resetPositionXRight, Player.transform.position.y, Player.transform.position.z);
        }

        if (Player.transform.position.y < resetPositionYDown)
        {
            // Then reset the player's position to the TOP
            Player.transform.position = new Vector3(Player.transform.position.x, resetPositionYUp, Player.transform.position.z);
        }

        if (Player.transform.position.y > resetPositionYUp)
        {
            // Then reset the player's position to the BOTTOM
            Player.transform.position = new Vector3(Player.transform.position.x, resetPositionYDown, Player.transform.position.z);
        }

        // ===========================================================================Asteroids position check!===========================================================================

        if (Asteroids.transform.position.x > resetPositionXRight)
        {
            // Then reset the asteroid's position to the LEFT
            Asteroids.transform.position = new Vector3(resetPositionXLeft, Asteroids.transform.position.y, Asteroids.transform.position.z);
        }

        if (Asteroids.transform.position.x < resetPositionXLeft)
        {
            // Then reset asteroid's position to the RIGHT
            Asteroids.transform.position = new Vector3(resetPositionXRight, Asteroids.transform.position.y, Asteroids.transform.position.z);
        }

        if (Asteroids.transform.position.y < resetPositionYDown)
        {
            // Then reset the asteroid's position to the TOP
            Asteroids.transform.position = new Vector3(Asteroids.transform.position.x, resetPositionYUp, Asteroids.transform.position.z);
        }

        if (Asteroids.transform.position.y > resetPositionYUp)
        {
            // Then reset the player's position to the BOTTOM
            Asteroids.transform.position = new Vector3(Asteroids.transform.position.x, resetPositionYDown, Asteroids.transform.position.z);
        }

    }
}
