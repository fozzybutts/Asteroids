using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(2);
        }
    }
}
