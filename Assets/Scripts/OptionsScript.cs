using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    [SerializeField] private GameObject Object;
    [SerializeField] private GameObject Object2;

    public void Deact()
    {
        Object.gameObject.SetActive(false);
        Object2.gameObject.SetActive(true);
    }


}
