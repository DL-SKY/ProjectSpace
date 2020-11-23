using ProjectSpace.Constants;
using ProjectSpace.Patterns;
using ProjectSpace.Services;
using ProjectSpace.UI.WindowsManager;
using ProjectSpace.UI.Windows.Loading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Application
{
    public class GameManager : Singleton<GameManager>
    {
        protected override void Awake()
        {
            base.Awake();
        }

        private void Start()
        {
            Initialize();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }


        //TODO
        private void Initialize()
        {
            var windowsManager = ComponentLocator.Resolve<WindowsManager>();
            windowsManager.CreateWindow<GameLoadingWindow>(GameLoadingWindow.prefabPath, Enums.EnumWindowsLayer.Loading, ConstantScenes.MAIN_MENU);
        }
    }
}
