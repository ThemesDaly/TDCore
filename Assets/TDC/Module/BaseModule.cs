using UnityEngine;

namespace TDC.Module
{
    public abstract class BaseModule<T> : MonoBehaviour, IModule
    {
        protected T type;
        protected IModule module;

        public virtual void Instance() => module = this;

        public abstract void Add();
        public abstract void Remove();
    }
}