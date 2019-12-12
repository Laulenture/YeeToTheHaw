using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public GameObject Bulletprefab;

    public Vector3 center;
    public Vector3 size;
    protected float fltTimer;

    bool timerActive = true;
    public int BulletNumber = 0;

    public float speed = 0f;

    //Audio related variables
    AudioSource m_MyAudioSource;
    bool m_Play;
    bool m_ToggleChange;

    // Start is called before the first frame update
    void Start()
    {
        ///Audio
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;


        SpawnBullet();
    }

    // Update is called once per frame
    void Update()
    {
        ///Audio
        //Check to see if you just set the toggle to positive
        if (m_Play == true && m_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            m_MyAudioSource.Play();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
        //Check if you just set the toggle to false
        if (m_Play == false && m_ToggleChange == true)
        {
            //Stop the audio
            m_MyAudioSource.Stop();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }

        ///Bullet spawn
        if (timerActive)
        {
            fltTimer += Time.deltaTime;
            if (fltTimer >= 2)
            {
                SpawnBullet();
                fltTimer = 0;
                BulletNumber += 1;
            }
        }
        
    }

    public void SpawnBullet()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2,size.x/2), Random.Range(-size.y / 2, size.y / 2), 20);
        //Instantiate(Bulletprefab, pos, Quaternion.identity);
        GameObject instBullet = Instantiate(Bulletprefab, pos, Quaternion.Euler(-90, 0, 0)) as GameObject;
        Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
        instBulletRigidbody.AddForce(Vector3.forward * -speed);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
