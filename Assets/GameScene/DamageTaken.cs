using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OpenCVForUnityExample;

public class DamageTaken : MonoBehaviour
{
    // Start is called before the first frame update
    public int vie = 3;
    public AudioSource sound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    private void OnTriggerEnter (Collider other)
    {

        Debug.Log("Hit by a bullet");
        vie -= 1;
        source.Play();

    }
}
