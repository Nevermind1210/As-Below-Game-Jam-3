using System;
using UnityEngine;

namespace UnityTemplateProjects
{
    [RequireComponent(typeof(Rigidbody))]
    public class BoatController : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private WaterController _waterController;

        [SerializeField] private float forwardForce = 10;
        [SerializeField] private float turningTorque = 50;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _waterController = GetComponent<WaterController>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && !WaterController.current.isGamePaused)
            {
                GoForward();
            }
        }

        void GoForward()
        {
            _rigidbody.AddForce(transform.forward* forwardForce, ForceMode.Acceleration);

            Vector3 torque = new Vector3(0, turningTorque, 0);
            _rigidbody.AddTorque(torque);
        }
    }
}