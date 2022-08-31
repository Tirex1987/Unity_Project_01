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

        Mathf.Sin(x);   // �����
        Mathf.Cos(x);   //�������
        Mathf.Tan(x);   //�������
        Mathf.Asin(x);   //��������
        Mathf.Acos(x);   //����������
        Mathf.Atan(x);   //����������

        //���������� ���� �������� ������������ ��� Z, �� ������� ����� ��������� ������,
        //��������� ����� ��� �, ����� � ����� x,y.
        Mathf.Atan2(y, x);

        Mathf.Min(2, 3, 1); //���������� �� ���� ����� float ��� int
        Mathf.Max(2, 3, 1); //���������� �� ���� ����� float ��� int

        Mathf.Round(1.75f); //2, ���������� ����� ��� ���� �� ���������� ������
        Mathf.Ceil(1.75f);  //2, ���������� ����� �� ���������� �������� ������
        Mathf.Floor(1.75f); //1, ���������� ���� �� ���������� �������� ������
        Mathf.Abs(-25); //25, ���������� �������� �����

        Mathf.Approximately(1.13f, 1.131f); //��������� ���� �������� float � �������� ���������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
