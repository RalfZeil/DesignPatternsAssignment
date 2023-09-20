using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    public class Bike : Vehicle
    {
        void Start()
        {
            base.DriveSpeed = 10f;
            base.RotationSpeed = 200f;
            base.ControllerIsVisible = true;
            base.Zoom = 1.2f;
        }
    }
}

