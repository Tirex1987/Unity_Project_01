using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<5; i++)
        {
            if (i == 3) continue;   // ������� � ��������� ��������
            if (i == 1) break;  // ����� �� �����
            print("Loop: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
