using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torches : MonoBehaviour
{
    
    Light Light;

    void Start()
    {
        Light=GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Light.intensity = 0 ;
            print("ballsack");
        }  
    }


}
