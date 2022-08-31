using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color darkGreen = new Color(0f, 0.25f, 0f); // альфа значение по умолчанию 1 - полностью непрозрачный цвет
        Color darkRedTranslucent = new Color(0.25f, 0f, 0f, 0.5f);

        print(Color.yellow.r);  //1, красный компонент желтого цвета
        print(Color.yellow.g);  //0.92, зеленый компонент желтого цвета
        print(Color.yellow.b);  //0.016, синий компонент желтого цвета
        print(Color.yellow.a);  //1, альфа-компонент желтого цвета

        print(Color.red);   //чистый красный (1,0,0)
        print(Color.green); //чистый зеленый (0,1,0)
        print(Color.blue);  //чистый синий (0,0,1)
        print(Color.cyan);  //циан, €ркий сине-зеленый (0,1,1)
        print(Color.magenta);  //фуксин, розово-фиолетовый (1,0,1)
        print(Color.yellow);  //при€тный дл€ глаз желтый (1, 0.92f, 0.016f)
        print(Color.black);  //черный (0,0,0)
        print(Color.white);  //белый (1,1,1)
        print(Color.gray);  //серый (0.5f, 0.5f, 0.5f)
        print(Color.grey);  //британское написание цвета серый (0.5f, 0.5f, 0.5f)
        print(Color.clear);  //полностью прозрачный (0,0,0,0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
