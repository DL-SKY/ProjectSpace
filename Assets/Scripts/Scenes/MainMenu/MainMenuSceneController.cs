using ProjectSpace.Services;
using ProjectSpace.UI.Windows.MainMenu;
using ProjectSpace.UI.WindowsManager;
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
