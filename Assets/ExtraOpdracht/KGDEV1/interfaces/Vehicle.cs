using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    public class Vehicle : MonoBehaviour, IControllable
    {
        protected float RotationSpeed { get; set; }
        protected float DriveSpeed { get; set; }
        public bool ControllerIsVisible { get; set; }

        private float zoom;

        public Vector3 Position
        {
            get
            {
                return transform.position;
            }
        }

        public float Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                zoom = value;
            }
        }

        public void Enter()
        {

        }

        public void Exit()
        {

        }

        public void HandleInput(float h, float v)
        {
            if (v < 0) h = -h;
            transform.Rotate(0, h * Time.deltaTime * RotationSpeed, 0, Space.Self);
            transform.Translate(v * transform.forward * Time.deltaTime * DriveSpeed, Space.World);
        }
    }
}