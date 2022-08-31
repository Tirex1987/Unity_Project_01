using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 3;

        switch(num)
        {
            case (0):
                print("Zero");
                break;
            case (1):
                print("One");
                break;
            case (2):
                print("Couple");
                break;
            case (3):
            case (4):
            case (5):
                print("Few");
                break;
            default:
                print("More than a few");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
