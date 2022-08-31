using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_SystemInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Screen.width);    // Ширина экрана в пикселах
        print(Screen.height);   // Высота экрана в пикселах

        print(SystemInfo.operatingSystem);  // версия операционной системы
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
