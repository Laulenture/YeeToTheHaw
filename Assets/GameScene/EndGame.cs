using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public DamageTaken dmg;
    public Bullets blt;
    public GameObject UiOver;
    public GameObject Player;
    public int BulletLimit = 5;

    private void Start()
    {

    }

    private void Update()
    {
        if (dmg.vie == 0)
        {
            Debug.Log("Out of life");
            Destroy(Player);
            UiOver.SetActive(true);
           
        }
        else if (blt.BulletNumber >= BulletLimit)
        {
            SceneManager.LoadScene(sceneName: "TestSc2");
        }

    }
      
 
}

    
