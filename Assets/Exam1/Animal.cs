using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected string animalName;
    void Init()
    {
        Debug.Log($"This is a {animalName}");

    }

    



    void Start()
    {
        Init();
        Debug.Log ($"This is a {animalName}");
    }
    void MakeSound()
    {
        
    }
   
}
