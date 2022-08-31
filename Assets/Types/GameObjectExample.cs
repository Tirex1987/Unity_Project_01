using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gObj = new GameObject("MyGO");   // Создает новый игровой объект с именем MyGO

        print(gObj.name);   // MyGO, имя игрового объект gObj

        Transform trans = gObj.GetComponent<Transform>();   //Определение ссылки trans на компонент Transform объекта gObj
        Transform trans2 = gObj.transform;  // Сокращенный способ доступа к тому же компоненту Transform

        Renderer rend = gObj.GetComponent<Renderer>();  // Вернет компонент Renderer
        Collider coll = gObj.GetComponent<Collider>();  // Вернет компонент Collider
        HelloWorld hwInstance = gObj.GetComponent<HelloWorld>();    //Получить экземпляр класса HelloWorld, присоединенный к игровому объекту gObj


        gObj.SetActive(false);  // Деактивирует объект gObj, в результате он становится невидимым и его код прекращает выполняться


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
