using ProjectSpace.Services;
using ProjectSpace.UI.Windows.Test;
using ProjectSpace.UI.WindowsManager;
using UnityEngine;

namespace ProjectSpace.Scenes.Test
{
    public class TestShipSceneController : MonoBehaviour
    {
        private void Awake()
        {
            var windowsManager = ComponentLocator.Resolve<WindowsManager>();
            windowsManager.CreateWindow<TestShipWindow>(TestShipWindow.prefabPath, Enums.EnumWindowsLayer.Main);
        }
    }
}
