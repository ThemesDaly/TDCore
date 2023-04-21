using UnityEngine;

namespace TDCore.BaseControllers
{
    public abstract class BaseModule<TypeModule> : MonoBehaviour, IModule
    {
        public TypeModule component { get; protected set; }
        protected IModule module;

        public virtual void Instance() => module = this;
        public abstract void ManualUpdate();
        public abstract void Destroy();
    }
}