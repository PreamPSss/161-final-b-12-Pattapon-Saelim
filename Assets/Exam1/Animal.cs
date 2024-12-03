using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    void Init(string AnimalName)
    {
        AnimalName = animalName;
    }

    



    void Start()
    {
        Init(animalName);
        
        Debug.Log ($"This is a {animalName}");
    }

   
}
