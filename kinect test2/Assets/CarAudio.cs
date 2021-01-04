using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAudio : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source.clip = clip;
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(Random.Range(2f, 12f));

        source.pitch = (Random.Range(0.6f, 1.2f));
        source.Play();

        yield return new WaitForSeconds(clip.length);
        StartCoroutine(PlaySound());
    }
}
