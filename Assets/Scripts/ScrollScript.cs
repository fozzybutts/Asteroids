using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public GameObject[] Asteroids;
    public GameObject Player;
    public float resetPositionXLeft = -31.0f;
    public float resetPositionXRight = 31.0f; 
    public float resetPositionYUp = 6.0f; 
    public float resetPositionYDown = -6.0f; 

    void Update()
    {
        if (Player != null)
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
        }

// ===========================================================================Asteroids position check!===========================================================================
        
        // Check each asteroid's position and reset if necessary
        for (int i = 0; i < Asteroids.Length; i++)
        {
            if (Asteroids[i] != null)
            {
                if (Asteroids[i].transform.position.x > resetPositionXRight)
                {
                    // Then wrap the asteroid's position to the LEFT
                    Asteroids[i].transform.position = new Vector3(resetPositionXLeft, Asteroids[i].transform.position.y, Asteroids[i].transform.position.z);
                }

                if (Asteroids[i].transform.position.x < resetPositionXLeft)
                {
                    // Then wrap the asteroid's position to the RIGHT
                    Asteroids[i].transform.position = new Vector3(resetPositionXRight, Asteroids[i].transform.position.y, Asteroids[i].transform.position.z);
                }

                if (Asteroids[i].transform.position.y < resetPositionYDown)
                {
                    // Then wrap the asteroid's position to the TOP
                    Asteroids[i].transform.position = new Vector3(Asteroids[i].transform.position.x, resetPositionYUp, Asteroids[i].transform.position.z);
                }

                if (Asteroids[i].transform.position.y > resetPositionYUp)
                {
                    // Then wrap the asteroid's position to the BOTTOM
                    Asteroids[i].transform.position = new Vector3(Asteroids[i].transform.position.x, resetPositionYDown, Asteroids[i].transform.position.z);
                }
            }
        }
    }
}
