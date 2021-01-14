using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class CollisionField : MonoBehaviour
    {
        private Collider collider;

        private Action onFieldExit;

        public void SetUpCallback(Collider collider, Action action)
        {
            this.collider = collider;
            onFieldExit = action;
        }

        private void OnTriggerExit(Collider other)
        {
            if (onFieldExit != null)
            {
                if (other == collider)
                {
                    onFieldExit();
                    onFieldExit = null;
                    collider = null;
                }

            }
        }
    }
}

