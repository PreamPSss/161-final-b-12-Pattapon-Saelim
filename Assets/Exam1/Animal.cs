using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    void Init()
    {
        this.animalName = animalName;
        Debug.Log($"This is a {animalName}");

    }

    



    void Start()
    {
        Init();
        Debug.Log ($"This is a {animalName}");
    }
    void Makesound()
    {
        string animalSound = "";
    }
}
