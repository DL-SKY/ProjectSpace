using ProjectSpace.Enums;
using ProjectSpace.Tools.Components;
using ProjectSpace.UI.Windows;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace ProjectSpace.UI.WindowsManager
{
    [Serializable]
    public class WindowsLayer
    {
        public EnumWindowsLayer key;
        public Transform value;

        public WindowsLayer(EnumWindowsLayer _key, Transform _value)
        {
            key = _key;
            value = _value;
        }
    }

    public class WindowsManager : AutoLocatorObject
    {
        public Action<WindowBase> OnCreateWindow;
        public Action<bool, WindowBase> OnCloseWindow;

        [Space()]
        #pragma warning disable CS0649
        [SerializeField] private List<WindowsLayer> layers;
        #pragma warning restore CS0649

        private List<WindowBase> windows = new List<WindowBase>();


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                GetLastWindow()?.OnClickEsc();
        }


        public T CreateWindow<T>(string _pathPrefab, EnumWindowsLayer _layer, object _data = null) where T : WindowBase
        {
            var prefab = Resources.Load<GameObject>(string.Format(_pathPrefab));
            var layer = layers.Find((x) => x.key == _layer)?.value ?? transform;
            var window = Instantiate(prefab, layer).GetComponent<T>();

            window.Initialize(_data);
            window.OnClose += OnCloseHandler;
            
            windows.Add(window);

            OnCreateWindow?.Invoke(window);

            return window;
        }

        public WindowBase GetLastWindow()
        {
            if (windows.Count < 1)
                return null;

            return windows[windows.Count - 1];
        }


        private void OnCloseHandler(bool _result, WindowBase _window)
        {
            _window.OnClose -= OnCloseHandler;

            if (windows.Contains(_window))
                windows.Remove(_window);

            OnCloseWindow?.Invoke(_result, _window);
        }
    }
}
