using NaughtyAttributes;
using UnityEngine;

namespace TDC.UI
{
    public abstract class AbstractWindow : BaseWindow
    {
        protected bool isInitTrue => window != null;
        protected bool isInitFalse => window == null;

        [BoxGroup(), ShowIf("isInitFalse"), SerializeField] private Value awakeState;
        [BoxGroup(), ShowIf("isInitFalse"), SerializeField] private Space _space;

        public Space space => _space;
        public Value state => structWindow.state;

        public delegate void OnUpdateState();
        public OnUpdateState onShow;
        public OnUpdateState onHide;

        private StructWindow structWindow;

        public override void Instance()
        {
            base.Instance();

            structWindow = new StructWindow(awakeState);
        }

        public override void Show()
        {
            structWindow.state = Value.Enable;
            onShow?.Invoke();
        }

        public override void Hide()
        {
            structWindow.state = Value.Disable;
            onHide?.Invoke();
        }
    }
}