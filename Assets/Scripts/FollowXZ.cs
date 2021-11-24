using System;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class FollowXZ : MonoBehaviour
    {
        [SerializeField] private Transform target;

        private void Update()
        {
            Vector3 position = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.position = position;
        }
    }
}