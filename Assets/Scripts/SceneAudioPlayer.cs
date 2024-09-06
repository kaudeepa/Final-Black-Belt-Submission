using UnityEngine;

public class SceneAudioPlayer : MonoBehaviour
{
    [Header("Audio Clip to Play When Scene Loads")]
    public AudioClip audioClip;

    private AudioSource audioSource;

    // This method is called when the scene loads
    void Start()
    {
        // Create an AudioSource component if one does not already exist
        audioSource = gameObject.AddComponent<AudioSource>();

        // Set the clip to the AudioSource
        audioSource.clip = audioClip;

        // Play the audio clip
        if (audioClip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No audio clip assigned to SceneAudioPlayer.");
        }
    }
}