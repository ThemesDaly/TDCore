using UnityEngine;

namespace TDCore.UI
{
    public abstract class BaseWindow<T> : MonoBehaviour, IWindow
    {
        public T component;
        protected IWindow window;

        public virtual void Instance() => window = this;

        public abstract void Hide();
        public abstract void Show();

    }
}