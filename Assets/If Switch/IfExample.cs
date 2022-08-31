using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool night = true;

        if (!night)
        {
            print("Day");
        } else
        {
            print("Night");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
