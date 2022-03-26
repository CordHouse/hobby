using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float rotspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 3;
        }
        transform.Rotate(0, 0, this.rotspeed);
        this.rotspeed *= 0.9980f;
    }
}
