using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BePerfect
{
    public class GreenButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        public void OnClick()
        {
            crystal.ActivateColour(Colour.Green);
        }
    }
}