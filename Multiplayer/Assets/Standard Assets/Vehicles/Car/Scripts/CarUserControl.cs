using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Photon.Pun;
namespace UnityStandardAssets.Vehicles.Car
{

    [RequireComponent(typeof (CarController))]

    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        PhotonView view;

        private void Awake()
        {
            view = GetComponent<PhotonView>();
            // get the car controller
            m_Car = GetComponent<CarController>();
            if (!view.IsMine)
            {
                Destroy(GetComponentInChildren<Camera>().gameObject);
            }

        }

        public void FixedUpdate()
        {
            if (view.IsMine)
            {
                // pass the input to the car!
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }
        }
    }
}
