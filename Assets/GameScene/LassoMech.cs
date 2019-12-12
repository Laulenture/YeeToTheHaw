using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OpenCVForUnityExample;

public class LassoMech : MonoBehaviour
{
    public float TimeLimit = 5;
    private int poingCompte = 0;
    public int PoingLimite = 20;
    public HandPoseEstimationExample handTracking;
    public bool Victory = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //comptage du nombre de fois où le joueur a fermer les poings
        if (handTracking.poingFermer == true)
        {
            poingCompte += 1;
            transform.localScale = new Vector3(100f, 100f, transform.localScale.z);
        }
        else if (handTracking.poingFermer == false)
        {
            transform.localScale = new Vector3(200f, 200f, transform.localScale.z);
        }


        //condition de victoire
       if(TimeLimit >= Time.deltaTime)
        {
            if (poingCompte == PoingLimite)
                Victory = true;

        }

    }
}
