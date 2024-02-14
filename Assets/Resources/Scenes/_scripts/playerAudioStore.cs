using UnityEngine;

public class playerAudioStore : MonoBehaviour
{
    public static playerAudioStore S;
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    private int currentClipIndex = 0;

    private void Start()
    {
        S = this;
        audioSource = GetComponent<AudioSource>();
    }

    

    
}