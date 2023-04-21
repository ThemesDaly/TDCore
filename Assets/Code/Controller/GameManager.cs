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

        print(GetModule<UI>().name);
        print(GetModule<UI>().Show<WindowMenu>().name);
        print(GetModule<UI>().Show<WindowMenu>().Hide<WindowGameplay>().name);

        GetModule<UI>().Show<WindowMenu>().Hide<WindowGameplay>();

        GetModule<UI>().Get<WindowGameplay>().Show();
    }
}