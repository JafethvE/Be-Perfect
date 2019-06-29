using UnityEngine;

namespace BePerfect
{
    public class OrangeButton : MonoBehaviour
    {
        [SerializeField]
        private Crystal crystal;

        public void OnClick()
        {
            crystal.ActivateColour(Colour.Orange);
        }
    }
}