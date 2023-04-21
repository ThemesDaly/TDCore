using System.Collections.Generic;
using UnityEngine;
using TDC.BaseControllers;

public class MonoController : BaseController<MonoController>
{
    private List<MonoModule> modules;

    private void Awake()
    {
        Instance();
    }

    public override void Instance()
    {
        base.Instance();

        modules = new List<MonoModule>();

        foreach (var module in FindObjectsOfType<MonoModule>())
            AddModule(module);
    }

    public override void AddModule(IModule module)
    {
        if (module is MonoModule mModule)
        {
            module.Instance();
            modules.Add(mModule);
        }
    }

    public override void RemoveModule(IModule module)
    {
        if (module is MonoModule mModule)
        {
            modules.Remove(mModule);
            module.Destroy();
        }
    }
}