using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    public class Player : MonoBehaviour, IViewable
    {
		private float zoom = 1f;

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

        const float PLAYER_SPEED = 10f;

        private IControllable vehicle;
        private IControllable target;
        private Renderer rend;

        void Awake()
        {
            rend = GetComponent<Renderer>();
        }

        void Start()
        {
            EventSystem.RaiseEvent(EventType.VIEW_CHANGED, this);
        }

        void Update()
        {
            if ( vehicle == null )
			{
				transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * PLAYER_SPEED, 0, Input.GetAxis("Vertical") * Time.deltaTime * PLAYER_SPEED);

				if (Time.frameCount % 20 == 0)
					CheckIfNearVehicle();

				EnterNearbyVehicle();
			}
			else
			{
				// Handle input on the vehicle
				vehicle.HandleInput(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
				transform.position = vehicle.Position;
				HandleVehicleExit();
			}
		}

		private void HandleVehicleExit()
		{
			// Let us get out
			if (Input.GetKeyDown(KeyCode.E))
			{
				transform.position = vehicle.Position;
				rend.enabled = true;
				vehicle.Exit();
				vehicle = null;
                EventSystem.RaiseEvent(EventType.VIEW_CHANGED, this);
                Debug.Log("EXIT");
			}
		}

		private void EnterNearbyVehicle()
		{
			// If we're near something, give the option to get in
			if (target != null)
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					
					vehicle = target;

					if (!vehicle.ControllerIsVisible)
					{
                        rend.enabled = false;
                    }

					vehicle.Enter();
                    EventSystem.RaiseEvent(EventType.VIEW_CHANGED, vehicle);
                    Debug.Log("ENTER");
				}
			}
		}

		private void CheckIfNearVehicle()
		{
			// Check if we're near an object
			Collider[] colliders = Physics.OverlapSphere(transform.position, 2f, 1 << LayerMask.NameToLayer("Controllable"));
			float dist = float.MaxValue;
			foreach (Collider c in colliders)
			{
				float d = Vector3.Distance(c.transform.position, transform.position);
				if (d < dist)
				{
					dist = d;
					target = c.GetComponent<IControllable>();
					// Debug.Log(target);
				}
			}

			// reset if there's nothing...
			if (colliders.Length == 0)
			{
				// Debug.Log("NOTHING");
				target = null;
			}
		}
	}
}