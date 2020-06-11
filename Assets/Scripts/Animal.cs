using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;
    public string name;

    public virtual void SayHello()
    {
        Balloon.SetActive(true);
    }
}
