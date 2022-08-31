using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "Golem")
        {
            Destroy(target.gameObject);
            Time.timeScale = 0f;
        }
    }

}
