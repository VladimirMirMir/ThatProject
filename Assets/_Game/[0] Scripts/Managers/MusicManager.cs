using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MusicManager : MonoBehaviour
{
    private static MusicManager s_instance;

    private AudioSource _source;
    private float _timer = 0;

    private void Awake()
    {
        s_instance = this;
        _source = GetComponent<AudioSource>();
        _source.playOnAwake = false;
        _source.loop = true;
        _source.Stop();
    }

    public static void PlaySoundInstant(AudioClip clip)
    {
        s_instance._source.Stop();
        s_instance._source.clip = clip;
        s_instance._source.Play();
    }

    public static void PlaySound(AudioClip clip, float fadeTime)
    {
        s_instance.StartCoroutine(PlaySoundRoutine(clip, fadeTime));
    }

    private static IEnumerator PlaySoundRoutine(AudioClip clip, float fadeTime)
    {
        s_instance._timer = 0;
        float step = 1 / fadeTime;
        while (s_instance._timer <= fadeTime)
        {
            yield return new WaitForEndOfFrame();
            s_instance._timer += Time.deltaTime;
            s_instance._source.volume -= step;
        }
        s_instance._source.volume = 0;
        s_instance._source.Stop();
        s_instance._source.clip = clip;
        s_instance._source.Play();
        s_instance._timer = 0;
        while (s_instance._timer <= fadeTime)
        {
            yield return new WaitForEndOfFrame();
            s_instance._timer += Time.deltaTime;
            s_instance._source.volume += step;
        }
        s_instance._source.volume = 1;
    }
}