using System;
using UnityEngine;

namespace BePerfect
{ 
    [Serializable]
    public class CrystalPart : MonoBehaviour
    {
        [SerializeField]
        private ColourMaterialDictionary materials;

        [SerializeField]
        private Colour colour;

        private bool active;

        [SerializeField]
        private new MeshRenderer renderer;

        public bool Active
        {
            get
            {
                return active;
            }
        }

        public void ActivateColour(Colour colour)
        {
            renderer.material = materials[colour];
            active = true;
        }

        public void Deactivate()
        {
            renderer.material = materials[Colour.Black];
            active = false;
        }

        public void Start()
        {
            active = false;
        }
    }
}