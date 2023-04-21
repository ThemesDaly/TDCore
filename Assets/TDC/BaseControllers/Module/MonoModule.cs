using TDC.BaseControllers;

public class MonoModule : BaseModule<MonoModule>
{
    public override void Instance()
    {
        base.Instance();

        print($"Module {GetType().Name} Instance");
    }

    public override void Destroy()
    {
        print($"Module {GetType().Name} Destroy");
    }
}