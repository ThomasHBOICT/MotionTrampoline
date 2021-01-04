using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    [SerializeField]
    public AudioClip lucht;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        PlayLucht();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void PlayLucht()
    {
        source.clip = lucht;
        source.Play();
    }
}