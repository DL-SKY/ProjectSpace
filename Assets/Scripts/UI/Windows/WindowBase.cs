using System;
using UnityEngine;

namespace ProjectSpace.UI.Windows
{
    public class WindowBase : MonoBehaviour
    {
        public Action<bool, WindowBase> OnClose;

        [Header("Main Settings")]
        [SerializeField] protected bool canUseEsc;


        public virtual void Initialize(object _data)
        {

        }

        public virtual void Close(bool _result = false)
        {
            OnClose?.Invoke(_result, this);
            Destroy(gameObject);
        }

        public virtual void OnClickEsc()
        {
            if (canUseEsc)
                Close();
        }
    }
}
