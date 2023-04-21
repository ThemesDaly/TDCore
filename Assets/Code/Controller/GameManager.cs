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

        print(GetModule<UIController>().name);
        print(GetModule<UIController>().Show<WindowMenu>().name);
        print(GetModule<UIController>().Show<WindowMenu>().Hide<WindowGameplay>().name);

        GetModule<UIController>().Show<WindowMenu>().Hide<WindowGameplay>();

        GetModule<UIController>().Get<WindowGameplay>().Show();
    }
}