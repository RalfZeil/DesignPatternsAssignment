using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest
{
    [RequireComponent(typeof(Camera))]
    public class FollowCam : MonoBehaviour
    {
        private Camera cameraComponent;
        private IViewable target;

        private float currentZoom = 1f;
        private float startZoom = 1f;
        private float targetZoom = 1f;
        private float zoomTimer = 1f;

        void Awake()
        {
            cameraComponent = GetComponent<Camera>();
        }

        private void Start()
        {
            EventSystem.Subscribe(EventType.VIEW_CHANGED, OnCameraChange);
        }

        private void OnDestroy()
        {
            EventSystem.Unsubscribe(EventType.VIEW_CHANGED, OnCameraChange);
        }

        void LateUpdate() {
            if ( target != null)
            {
                Vector3 position = transform.position;
                position.x = target.Position.x;
                position.z = target.Position.z;
                transform.position = position;

                if ( zoomTimer < 1 )
                {
                    zoomTimer = Mathf.Clamp01(zoomTimer + Time.deltaTime);
                    currentZoom = Mathf.Lerp(startZoom, targetZoom, zoomTimer);

                    cameraComponent.orthographicSize = 10f * currentZoom;
                }
            }
        }

        private void OnCameraChange(EventType evt, object value)
        {
            IViewable newTarget = (IViewable)value;

            if(target != newTarget) 
            { 
                target = newTarget;
                UpdateZoom(target.Zoom);
            }
        }

        void UpdateZoom( float newZoom )
        {
            startZoom = currentZoom;
            targetZoom = newZoom;
            zoomTimer = 0;
        }
    }
}