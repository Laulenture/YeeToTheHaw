using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public GameObject Bulletprefab;

    public Vector3 center;
    public Vector3 size;
    public float fltTimer;

    bool timerActive = true;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            fltTimer += Time.deltaTime;
            if (fltTimer >= 2)
            {
                SpawnBullet();
                fltTimer = 0;
            }
        }
    }

    public void SpawnBullet()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2,size.x/2), Random.Range(-size.y / 2, size.y / 2), 20);
        Instantiate(Bulletprefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
