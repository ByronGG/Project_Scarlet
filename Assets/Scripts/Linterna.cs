using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light luzLinterna;
    public bool actiLuz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            actiLuz = !actiLuz;
            if(actiLuz == true)
            {
                luzLinterna.enabled = true;
            }
            if (actiLuz == false)
            {
                luzLinterna.enabled = false;
            }
        }
    }
}
