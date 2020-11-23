using ProjectSpace.Interfaces.Pool;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Pool
{
    public class LocalPoolManager : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform poolParent;

        [Header("Autoinitializing")]
        [SerializeField] private bool isAutoInit = false;
        [SerializeField] private uint defaultPoolSize = 5;

        private List<IPoolObject> pool = new List<IPoolObject>();


        private void Awake()
        {
            if (poolParent == null)
                poolParent = transform;

            if (isAutoInit)
                Initialize((int)defaultPoolSize);
        }


        public void Initialize(int _poolSize)
        {
            if (_poolSize < 1)
                return;

            pool.Clear();

            for (int i = 0; i < _poolSize; i++)
                CreatePoolObject();
        }

        public T GetPoolObject<T>() where T : MonoBehaviour
        {
            var freePoolObject = pool.Find(x => !x.IsUsing);

            if (freePoolObject == null)
                freePoolObject = CreatePoolObject();

            freePoolObject.ShowObject();

            return freePoolObject.PoolObject.GetComponent<T>();
        }

        public T GetPoolObject<T>(Transform _parent) where T : MonoBehaviour
        {
            var freePoolObject = GetPoolObject<T>();
            freePoolObject.transform.SetParent(_parent);

            return freePoolObject;
        }


        private IPoolObject CreatePoolObject()
        {
            if (prefab == null)
            {
                Debug.LogError("[LocalPoolManager " + name + "] : Prefab is NULL!");
                return null;
            }

            var newObject = Instantiate(prefab, poolParent);
            newObject.SetActive(false);

            var newPoolObject = newObject.GetComponent<IPoolObject>();
            newPoolObject.OnReturnObject += OnReturnPoolObjectHandler;
            pool.Add(newPoolObject);

            return newPoolObject;
        }

        private void OnReturnPoolObjectHandler(GameObject _poolObject)
        {
            _poolObject.transform.SetParent(poolParent);
            _poolObject.SetActive(false);
        }
    }
}
