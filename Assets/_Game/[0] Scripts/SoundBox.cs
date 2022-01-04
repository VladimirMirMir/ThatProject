using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundBox : MonoBehaviour
{
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        if (_source.isPlaying)
            _source.Stop();
        if (_source.clip.name != clip.name)
            _source.clip = clip;
        _source.Play();
    }
}