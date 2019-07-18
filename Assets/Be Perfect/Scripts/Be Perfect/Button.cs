using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BePerfect
{ 
    public class Button : MonoBehaviour
    {
        [SerializeField]
        private Colour colour;

        [SerializeField]
        private Crystal crystal;

        public void OnClick()
        {
            crystal.ToggleColour(colour);
        }
    }
}