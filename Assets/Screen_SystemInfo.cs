using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_SystemInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Screen.width);    // ������ ������ � ��������
        print(Screen.height);   // ������ ������ � ��������

        print(SystemInfo.operatingSystem);  // ������ ������������ �������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
