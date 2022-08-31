using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public List<string> sList;

    // Start is called before the first frame update
    void Start()
    {
        sList = new List<string>();

        sList.Add("Experience");
        sList.Add("is");
        sList.Add("what");
        sList.Add("you");
        sList.Add("get");
        sList.Add("when");
        sList.Add("you");
        sList.Add("don't");
        sList.Add("get");
        sList.Add("what");
        sList.Add("you");
        sList.Add("wanted");

        sList.Remove("what");
        sList.Insert(2, "xxx");
        sList.RemoveAt(2);
        sList.Insert(2, "what");

        print("sList Count = " + sList.Count);
        print("The 0th element is: " + sList[0]);
        print("The 3th element is: " + sList[3]);

        string str = "";
        foreach(string sTemp in sList)
        {
            str += sTemp + " ";
        }
        print(str);

        print(sList.IndexOf("you"));

        string[] array = sList.ToArray();
        sList.Clear();


        //Ступенчатые списки
        List<List<string>> jaggedList = new List<List<string>>();

        jaggedList.Add(new List<string>());
        jaggedList.Add(new List<string>());

        jaggedList[0].Add("Hello");
        jaggedList[0].Add("World");

        jaggedList.Add(new List<string>(new string[] { "complex", "initialization" }));

        string str2 = "";
        foreach(List<string> sL in jaggedList)
        {
            foreach(string sTemp in sL)
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
