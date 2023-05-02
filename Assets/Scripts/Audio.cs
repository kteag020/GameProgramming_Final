using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource gameAudio;
    // Start is called before the first frame update
    void Start()
    {
        gameAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}