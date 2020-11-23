using ProjectSpace.Interfaces.Pool;
using System;
using UnityEngine;

namespace ProjectSpace.Pool
{
    public class LocalPoolObject : MonoBehaviour, IPoolObject
    {
        public Action<GameObject> OnReturnObject { get; set; }

        public bool IsUsing { get; private set; }
        public GameObject PoolObject { get { return gameObject; } }

        public void ShowObject()
        {
            IsUsing = true;
            gameObject.SetActive(true);            
        }

        public void ReturnObject()
        {
            IsUsing = false;
            OnReturnObject?.Invoke(gameObject);
        }
    }
}
