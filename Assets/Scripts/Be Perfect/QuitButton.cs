using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BePerfect
{ 
    public class QuitButton : MonoBehaviour
    {
        public void OnClick()
        {
            Application.Quit();
        }
    }
}