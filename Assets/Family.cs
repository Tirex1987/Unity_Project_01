using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human
{
    public string name;
    public Human partner;

    static public void Marry(Human h0, Human h1)
    {
        h0.partner = h1;
        h1.partner = h0;
    }
}

public class Family : MonoBehaviour
{
    public Human husband;
    public Human wife;

    // Start is called before the first frame update
    void Start()
    {
        husband = new Human();
        husband.name = "Jeremy";
        wife = new Human();
        wife.name = "Melanie";

        Human.Marry(wife, husband);

        print(wife.partner.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
