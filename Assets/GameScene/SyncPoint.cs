using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OpenCVForUnityExample;

public class SyncPoint : MonoBehaviour
{

    public HandPoseEstimationExample handTracking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((float)handTracking.mainPos.x - 100f, (float)handTracking.mainPos.y - 100f, 49.0f);
        
    }
}
