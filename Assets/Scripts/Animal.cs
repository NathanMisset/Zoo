using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField]
    protected GameObject Balloon;
    [SerializeField]
    protected Text text;
    public string name;

    [SerializeField]
    protected string type;
    protected bool hasTrick = false;

    public virtual void SayHello()
    {
        Balloon.SetActive(true);
    }
    public virtual void EatMeat()
    {
        if (type == "Carnivore" || type == "Omnivoor")
        {
            Balloon.SetActive(true);
        }
    }

    public virtual void EatLeaves()
    {
        if (type == "Herbivore" || type == "Omnivoor")
        {
            Balloon.SetActive(true);
        }
    }

    public virtual void PerformTrick()
    {
        if (hasTrick = true)
        {
            StartCoroutine(DoTrick());
        }
        
    }

    public IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }
    public IEnumerator DoTwril()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(0, i, 0);
            yield return new WaitForEndOfFrame();
        }
    }
}
