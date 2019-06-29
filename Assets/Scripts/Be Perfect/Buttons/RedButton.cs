using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BePerfect
{ 
    public class RedButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        public void OnClick()
        {
            crystal.ActivateColour(Colour.Red);
        }
    }
}