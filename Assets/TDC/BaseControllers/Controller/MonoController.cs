using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using TDCore.BaseControllers;

public abstract class MonoController : BaseController<MonoController>
{
    [BoxGroup(), SerializeField] private Mode mode = Mode.Update;

    private List<MonoModule> modules;

    private void Awake()
    {
        Instance();
    }

    private void Update()
    {
        if (mode == Mode.Update) ManualUpdate();
    }

    private void FixedUpdate()
    {
        if (mode == Mode.FixedUpdate) ManualUpdate();
    }

    private void LateUpdate()
    {
        if (mode == Mode.LateUpdate) ManualUpdate();
    }

    public virtual void ManualUpdate()
    {
        foreach (MonoModule module in modules)
            module.ManualUpdate();
    }

    public override void Instance()
    {
        base.Instance();

        modules = new List<MonoModule>();

        foreach (MonoModule module in FindObjectsOfType<MonoModule>())
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