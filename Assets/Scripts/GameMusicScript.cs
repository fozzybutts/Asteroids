using UnityEngine;

public class GameMusicScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip gameMusicClip;

    void Start()
    {
        audioSource.clip = gameMusicClip;
        audioSource.Play();
    }
}
