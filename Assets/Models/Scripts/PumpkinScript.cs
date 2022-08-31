using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinScript : MonoBehaviour
{

    void Update()
    {
        // Destory pumpkins after pass the golem
        if(transform.position.y < -3f)  
        {
            Destroy(gameObject);
        }
    }

    // Game Pause
    void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "Golem")
        {
            Destroy(target.gameObject);
            Time.timeScale = 0f;
        }
    }

}
