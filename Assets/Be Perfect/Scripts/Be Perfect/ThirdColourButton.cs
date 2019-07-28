using UnityEngine;

namespace BePerfect
{
    public class ThirdColourButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        [SerializeField]
        private Colour colour;

        public void OnClick()
        {
            crystal.ActivateThirdColour(colour);
        }
    }
}
