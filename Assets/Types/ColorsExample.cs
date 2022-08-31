using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color darkGreen = new Color(0f, 0.25f, 0f); // ����� �������� �� ��������� 1 - ��������� ������������ ����
        Color darkRedTranslucent = new Color(0.25f, 0f, 0f, 0.5f);

        print(Color.yellow.r);  //1, ������� ��������� ������� �����
        print(Color.yellow.g);  //0.92, ������� ��������� ������� �����
        print(Color.yellow.b);  //0.016, ����� ��������� ������� �����
        print(Color.yellow.a);  //1, �����-��������� ������� �����

        print(Color.red);   //������ ������� (1,0,0)
        print(Color.green); //������ ������� (0,1,0)
        print(Color.blue);  //������ ����� (0,0,1)
        print(Color.cyan);  //����, ����� ����-������� (0,1,1)
        print(Color.magenta);  //������, ������-���������� (1,0,1)
        print(Color.yellow);  //�������� ��� ���� ������ (1, 0.92f, 0.016f)
        print(Color.black);  //������ (0,0,0)
        print(Color.white);  //����� (1,1,1)
        print(Color.gray);  //����� (0.5f, 0.5f, 0.5f)
        print(Color.grey);  //���������� ��������� ����� ����� (0.5f, 0.5f, 0.5f)
        print(Color.clear);  //��������� ���������� (0,0,0,0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
