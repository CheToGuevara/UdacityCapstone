using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCollider : MonoBehaviour
{


    public Playback m_videoplayer;
    public AudioSource[] list2Stop;
    // Use this for initialization
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hola");
        if (other.CompareTag("MainCamera"))
            m_videoplayer.Play();

        foreach(AudioSource sour in list2Stop)
        {
            sour.Stop();
        }
    }
}
