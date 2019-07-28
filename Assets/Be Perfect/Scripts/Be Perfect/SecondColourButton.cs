using UnityEngine;

namespace BePerfect
{
    public class SecondColourButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        [SerializeField]
        private Colour colour;

        public void OnClick()
        {
            crystal.ActivateSecondColour(colour);
        }
    }
}
