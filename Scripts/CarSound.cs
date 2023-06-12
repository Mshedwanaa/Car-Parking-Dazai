using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CarSound : MonoBehaviour
{
    public Rigidbody carRigidbody;
    public float minPitch = 0.5f;
    public float maxPitch = 2.0f;
    public float minVolume = 0.1f;
    public float maxVolume = 0.5f;
    public float speedToPitchRatio = 0.01f;
    public float speedToVolumeRatio = 0.01f;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void Update()
    {
        float speed = carRigidbody.velocity.magnitude;
        float pitch = Mathf.Lerp(minPitch, maxPitch, speed * speedToPitchRatio);
        float volume = Mathf.Lerp(minVolume, maxVolume, speed * speedToVolumeRatio);

        audioSource.pitch = pitch;
        audioSource.volume = volume;

        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
