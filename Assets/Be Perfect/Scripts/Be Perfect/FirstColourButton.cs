using UnityEngine;

namespace BePerfect
{
    public class FirstColourButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        [SerializeField]
        private Colour colour;

        public void OnClick()
        {
            crystal.ActivateFistColour(colour);
        }
    }
}