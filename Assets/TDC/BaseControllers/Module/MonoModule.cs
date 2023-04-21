using UnityEngine;
using NaughtyAttributes;

using TDCore.BaseControllers;
using System;

public class MonoModule : BaseModule<MonoModule>
{
    public override void Instance()
    {
        base.Instance();

        component = this;

        print($"Module {GetType().Name} Instance");
    }

    public override void ManualUpdate()
    {
        print($"Module {GetType().Name} Update");
    }

    public override void Destroy()
    {
        print($"Module {GetType().Name} Destroy");
    }
}