using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public string[] sArray;

    // Start is called before the first frame update
    void Start()
    {
        sArray = new string[10];    // ������ ������ �������

        sArray[0] = "These";
        sArray[1] = "are";
        sArray[5] = "some";
        sArray[8] = "words";

        print("The length of sArray is: " + sArray.Length);

        string str = "";
        foreach(string sTemp in sArray)
        {
            str += "|" + sTemp;
        }
        print(str);

        //��������� � �������������� ������ ������������ 4 
        string[] sA = new string[] { "A", "B", "C", "D" };

        System.Array.IndexOf(sA, "C");  // ������ ������ ������� � ������� sA �� ������� "�" � ������ ��� ������. ���� ����� ������ ���, ������ -1

        System.Array.Resize(ref sA, 6); // ������� ������ ������� [ "A", "B", "C", "D", null, null ]
        System.Array.Resize(ref sA, 3); // [ "A", "B", "C" ]

        List<string> sL = new List<string>(sA); // ������� ������ List sL, ���������� ����� ��������� ������� sA

        //��� ���������� � ������������� ������ List ����� ������������ ��������� ������������� �������
        List<string> sL2 = new List<string>(new string[] { "A", "B", "F" });


        //����������� �������
        string[,] sArray2d;
        sArray2d = new string[4, 4];

        sArray2d[0, 0] = "A";
        sArray2d[1, 2] = "B";

        print("The Length of sArray2d is: " + sArray2d.Length); //16


        //����������� �������
        string[][] jArray;
        jArray = new string[4][];

        jArray[0] = new string[4];
        jArray[0][0] = "A";
        jArray[1] = new string[] { "E", "F", "G" };
        jArray[2] = new string[] { "H", "I" };
        jArray[3] = new string[4];

        string str2 = "";
        foreach(string[] sArray in jArray)
        {
            foreach(string sTemp in sArray)
            {
                if (sTemp != null)
                {
                    str2 += " | " + sTemp;
                } else
                {
                    str2 += " | ";
                }
            }
            str2 += " | \n";
        }
        print(str2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
