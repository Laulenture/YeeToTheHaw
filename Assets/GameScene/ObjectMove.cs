using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OpenCVForUnityExample;

public class ObjectMove : MonoBehaviour
{

    public FaceDetectionWebCamTextureExample webcam;
    //public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //changer la position de l'objet en fonction du tracking obtenue avec la camera
        transform.position = new Vector3((float)webcam.rect.x - 100f, transform.position.y, transform.position.z);
    }
}
