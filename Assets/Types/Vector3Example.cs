using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Example : MonoBehaviour
{
    Vector3 position = new Vector3(0.0f, 3.0f, 4.0f);

    // Start is called before the first frame update
    void Start()
    {
        print(position.x);
        print(position.y);
        print(position.z);
        print(position.magnitude); //ƒлина вектора от точки (0,0,0)

        position.Normalize();// пропорционально пересчитывает значени€ x, y, z так, что величина magnitude будет равна 1

        print(Vector3.zero);    // (0,0,0)
        print(Vector3.one);     // (1,1,1)
        print(Vector3.right);   // (1,0,0)
        print(Vector3.up);      // (0,1,0)
        print(Vector3.forward); // (0,0,1)

        Vector3 position2 = new Vector3(2.0f, 2.0f, 2.0f);
        print(Vector3.Cross(position, position2));  // векторное произведение двух экземпл€ров Vector3
        print(Vector3.Dot(position, position2));    // скал€рное произвденеие двух экземпл€ров Vector3

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
