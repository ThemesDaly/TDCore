using UnityEngine;

namespace TDCore.BaseControllers
{
    public abstract class BaseController<TypeController> : MonoBehaviour, IController
    {
        public TypeController component { get; protected set; }
        protected IController controller;

        public virtual void Instance() => controller = this;

        public abstract void AddModule(IModule module);
        public abstract void RemoveModule(IModule module);
        public abstract TypeModule GetModule<TypeModule>();

    }
}