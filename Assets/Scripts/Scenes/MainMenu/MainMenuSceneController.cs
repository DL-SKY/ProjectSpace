using ProjectSpace.Constants;
using ProjectSpace.Services;
using ProjectSpace.UI.WindowsManager;
using ProjectSpace.UI.Windows.Loading;
using ProjectSpace.UI.Windows.MainMenu;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Scenes.MainMenu
{
    public class MainMenuSceneController : MonoBehaviour
    {
        private void Awake()
        {
            var windowsManager = ComponentLocator.Resolve<WindowsManager>();
            windowsManager.CreateWindow<MainMenuWindow>(MainMenuWindow.prefabPath, Enums.EnumWindowsLayer.Main);
        }
    }
}
