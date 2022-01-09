using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEffectsManager : MonoBehaviour
{
    private static SoundEffectsManager s_instance;

    private AudioSource _source;

    private void Awake()
    {
        s_instance = this;
        _source = GetComponent<AudioSource>();
    }

    public static void PlaySound(AudioClip clip)
    {
        if (s_instance._source.isPlaying)
            s_instance._source.Stop();
        if (s_instance._source.clip != clip)
            s_instance._source.clip = clip;
        s_instance._source.Play();
    }
}