using UnityEngine;

namespace ProjectSpace.Tools.Components
{
    public class DontDestroyObject : MonoBehaviour
    {
        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
