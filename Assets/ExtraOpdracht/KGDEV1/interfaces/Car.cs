using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    public class Car : Vehicle
    {
        private void Start()
        {
            base.DriveSpeed = 20f;
            base.RotationSpeed = 180f;
            base.Zoom = 2f;
        }
    }
}