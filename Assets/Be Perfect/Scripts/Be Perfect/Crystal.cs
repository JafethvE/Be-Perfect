using System;
using UnityEngine;

namespace BePerfect
{ 
    [Serializable]
    public class Crystal : MonoBehaviour
    {
        [SerializeField]
        private CrystalPart[] colourSegments;

        private Colour firstColour, secondColour, thirdColour;

        public void ActivateFistColour(Colour colour)
        {
            firstColour = colour;
            foreach(CrystalPart crystalPart in colourSegments)
            {
                crystalPart.ActivateColour(firstColour);
            }
        }

        public void ActivateSecondColour(Colour colour)
        {
            int i = 1;
            secondColour = colour;
            foreach (CrystalPart crystalPart in colourSegments)
            {
                if(i == 1)
                {
                    crystalPart.ActivateColour(secondColour);
                    i++;
                }
                else if(i == 2)
                {
                    crystalPart.ActivateColour(firstColour);
                    i = 1;
                }
            }
        }

        public void ActivateThirdColour(Colour colour)
        {
            int i = 1;
            thirdColour = colour;
            foreach (CrystalPart crystalPart in colourSegments)
            {
                if (i == 1)
                {
                    crystalPart.ActivateColour(thirdColour);
                    i++;
                }
                else if (i == 2)
                {
                    crystalPart.ActivateColour(secondColour);
                    i++;
                }
                else if(i == 3)
                {
                    crystalPart.ActivateColour(firstColour);
                    i = 1;
                }
            }
        }
    }
}