using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�������� ������ �� -45 �������� ������������ ������� ��� �, ������� � ����������
        //����� �������� �� ������� ��� � ������������� ����������� ����� ��� Z ��� ����� 45 ��������.
        Quaternion lookUp45Deg = Quaternion.Euler(-45f, 0f, 0f);

        print(lookUp45Deg.eulerAngles); // (315, 0, 0) ������� �������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
