using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    public class Bus : Vehicle
    {
        private void Start()
        {
            base.DriveSpeed = 10f;
            base.RotationSpeed = 100f;
            base.Zoom = 3f;
        }
    }
}