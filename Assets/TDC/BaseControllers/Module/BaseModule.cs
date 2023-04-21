using UnityEngine;

namespace TDC.BaseControllers
{
    public abstract class BaseModule<T> : MonoBehaviour, IModule
    {
        protected T type;
        protected IModule module;

        public virtual void Instance() => module = this;
        public abstract void Destroy();
    }
}