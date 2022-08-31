using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;

        while (i<3)
        {
            print("Loop: " + i);
            i++;
        }

        int j = 10;

        do
        {
            print("Loop: " + j++);
        } while (j < 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
