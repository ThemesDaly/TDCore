using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoController
{
    private void Start()
    {
        GameObject player = new GameObject("Instance Player");
        var pController = player.AddComponent<PlayerController>();

        AddModule(pController);

        RemoveModule(pController);
    }
}