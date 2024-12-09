using UnityEngine;

public class TitleMusicScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip titleMusicClip;

    void Start()
    {
        audioSource.clip = titleMusicClip;
        audioSource.Play();
    }
}
