using UnityEngine;

namespace TDC.BaseControllers
{
    public abstract class BaseController<T> : MonoBehaviour, IController
    {
        protected T type;
        protected IController controller;

        public virtual void Instance() => controller = this;

        public abstract void AddModule(IModule module);
        public abstract void RemoveModule(IModule module);

    }
}