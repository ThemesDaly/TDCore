using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField] public WindowLoader window;

    void Start()
    {
        window.Hide();
    }
}
