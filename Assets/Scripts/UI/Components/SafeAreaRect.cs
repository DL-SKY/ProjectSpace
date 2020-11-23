using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.UI.Components
{
    public class SafeAreaRect : MonoBehaviour
    {
        private RectTransform rect;


        private void Awake()
        {
            rect = GetComponent<RectTransform>();
            ApplyOffset();
        }


        private void ApplyOffset()
        {
            var safeArea = Screen.safeArea;
            var anchorMin = safeArea.position;
            var anchorMax = safeArea.position + safeArea.size;

            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
            
            rect.anchorMin = anchorMin;
            rect.anchorMax = anchorMax;
        }
    }
}
