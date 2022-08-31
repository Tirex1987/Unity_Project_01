using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(!true);
        print(true && false);
        print(true || false);
        print(true & false);
        print(true | false);
        print(2 * 2 * 2 & 2 * 2 * 2 * 3);
        print(2 * 2 * 2 | 2 * 2 * 2 * 3);

        bool tf = true || false && false;

        print(tf == true);

        print(10 != 10);
        print(20 > 10);
        print(3.14f <= Mathf.PI);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
