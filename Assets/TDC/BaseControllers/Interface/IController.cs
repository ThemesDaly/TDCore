public interface IController
{
    void Instance();
    void AddModule(IModule module);
    void RemoveModule(IModule module);
}
