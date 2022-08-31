using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    public Dictionary<string, string> statesDict;

    // Start is called before the first frame update
    void Start()
    {
        statesDict = new Dictionary<string, string>();

        statesDict.Add("MD", "MaryLand");
        statesDict.Add("TX", "Texas");
        statesDict.Add("PA", "Pennsylvania");
        statesDict.Add("CA", "California");
        statesDict.Add("MI", "Michigan");

        print("There are " + statesDict.Count + " elements in statesDict");

        foreach(KeyValuePair<string, string> kvp in statesDict)
        {
            print(kvp.Key + ": " + kvp.Value);
        }

        print("MI is" + statesDict["MI"]);

        statesDict["BC"] = "British Columbia"; // Т.к. элемента с таким ключом нет в коллекции, он будет добавлен

        foreach(string k in statesDict.Keys)
        {
            print(k + " is " + statesDict[k]);
        }

        statesDict.Clear();

        //Объявление и инициализация словаря
        Dictionary<int, string> dIS = new Dictionary<int, string>
        {
            {0, "Zero"},
            {1, "One" },
            {10, "Ten" },
            {1234567890, "A lot!" }
        };

        print(dIS.ContainsKey(1));  // Вернет true, если ключ 1 присутствует в словаре
        print(dIS.ContainsValue("A lot!")); // Вернет true, если значение "A lot!" присутствует в словаре
        dIS.Remove(10);     // Удалит из словаря пару ключ-значение с ключом 10
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
