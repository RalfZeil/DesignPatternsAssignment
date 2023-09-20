using UnityEngine;

namespace InterfaceTest
{
    public delegate void ViewChanged( float zoom );

    public interface IControllable : IViewable
    {
        public bool ControllerIsVisible { get; set; }
        public void Enter();
        public void Exit();

        void HandleInput(float h, float v);
    }

    public interface IViewable
    {
        Vector3 Position { get; }
        float Zoom{ get; set; }
    }
}