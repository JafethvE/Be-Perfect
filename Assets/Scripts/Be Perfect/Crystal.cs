using System;
using UnityEngine;

namespace BePerfect
{ 
    [Serializable]
    public class Crystal : MonoBehaviour
    {
        [SerializeField]
        private ColourCrystalPartDictionary colouredParts;

        public void ActivateColour(Colour colour)
        {
            colouredParts[colour].Activate();
        }

        public void DeactivateColour(Colour colour)
        {
            colouredParts[colour].Deactivate();
        }

        public void ToggleColour(Colour colour)
        {
            if(colouredParts[colour].Active)
            {
                colouredParts[colour].Deactivate();
            }
            else
            {
                colouredParts[colour].Activate();
            }
        }
    }
}