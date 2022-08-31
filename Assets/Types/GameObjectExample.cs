using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gObj = new GameObject("MyGO");   // ������� ����� ������� ������ � ������ MyGO

        print(gObj.name);   // MyGO, ��� �������� ������ gObj

        Transform trans = gObj.GetComponent<Transform>();   //����������� ������ trans �� ��������� Transform ������� gObj
        Transform trans2 = gObj.transform;  // ����������� ������ ������� � ���� �� ���������� Transform

        Renderer rend = gObj.GetComponent<Renderer>();  // ������ ��������� Renderer
        Collider coll = gObj.GetComponent<Collider>();  // ������ ��������� Collider
        HelloWorld hwInstance = gObj.GetComponent<HelloWorld>();    //�������� ��������� ������ HelloWorld, �������������� � �������� ������� gObj


        gObj.SetActive(false);  // ������������ ������ gObj, � ���������� �� ���������� ��������� � ��� ��� ���������� �����������


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
