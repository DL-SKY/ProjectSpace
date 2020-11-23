using ProjectSpace.Constants;
using ProjectSpace.Services;
using ProjectSpace.UI.Windows.Loading;
using UnityEngine;

namespace ProjectSpace.UI.Windows.MainMenu
{
    public class MainMenuWindow : WindowBase
    {
        public const string prefabPath = @"Prefabs\UI\Windows\MainMenu\MainMenuWindow";


        private void OnEnable()
        {
            Debug.LogError("OnEnable");
        }


        public void OnClickTest()
        {
            //var windowsManager = ComponentLocator.Resolve<WindowsManager.WindowsManager>();
            //windowsManager.CreateWindow<GameLoadingWindow>(GameLoadingWindow.prefabPath, Enums.EnumWindowsLayer.Loading, ConstantScenes.TEST_SCENE);

            //Close();
        }        
    }
}
