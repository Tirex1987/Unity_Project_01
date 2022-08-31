using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Mathf.PI;
        float y = Mathf.PI / 2;

        Mathf.Sin(x);   // синус
        Mathf.Cos(x);   //косинус
        Mathf.Tan(x);   //тангенс
        Mathf.Asin(x);   //арксинус
        Mathf.Acos(x);   //арккосинус
        Mathf.Atan(x);   //арктангенс

        //¬озвращает угол поворота относительно оси Z, на который нужно повернуть объект,
        //смотр€щий вдоль оси ’, лицом к точке x,y.
        Mathf.Atan2(y, x);

        Mathf.Min(2, 3, 1); //Ќаименьшее из трех чисел float или int
        Mathf.Max(2, 3, 1); //Ќаибольшее из трех чисел float или int

        Mathf.Round(1.75f); //2, округление вверх или вниз до ближайшего целого
        Mathf.Ceil(1.75f);  //2, округление вверх до следующего большего целого
        Mathf.Floor(1.75f); //1, округление вниз до следующего меньшего целого
        Mathf.Abs(-25); //25, абсолютное значение числа

        Mathf.Approximately(1.13f, 1.131f); //—равнение двух значений float с заданной точностью
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
