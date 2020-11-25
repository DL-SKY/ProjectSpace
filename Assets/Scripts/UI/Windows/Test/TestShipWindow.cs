using ProjectSpace.Constants;
using ProjectSpace.Services;
using ProjectSpace.UI.Windows.Loading;

namespace ProjectSpace.UI.Windows.Test
{
    public class TestShipWindow : WindowBase
    {
        public const string prefabPath = @"Prefabs\UI\Windows\Test\TestShipWindow";


        public override void OnClickEsc()
        {
            var windowsManager = ComponentLocator.Resolve<WindowsManager.WindowsManager>();
            windowsManager.CreateWindow<GameLoadingWindow>(GameLoadingWindow.prefabPath, Enums.EnumWindowsLayer.Loading, ConstantScenes.MAIN_MENU);

            Close();
        }
    }
}
