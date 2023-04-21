using UnityEngine;

namespace TDCore.UI
{
    public abstract class BaseWindow : MonoBehaviour, IWindow
    {
        protected IWindow window;

        public virtual void Instance() => window = this;

        public abstract void Hide();
        public abstract void Show();

    }
}