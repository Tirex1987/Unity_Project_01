using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ѕовернет камеру на -45 градусов относительно красной оси ’, котора€ в результате
        //будет смотреть на игровой мир в положительном направлении вдоль оси Z под углом 45 градусов.
        Quaternion lookUp45Deg = Quaternion.Euler(-45f, 0f, 0f);

        print(lookUp45Deg.eulerAngles); // (315, 0, 0) эйлеров поворот
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
