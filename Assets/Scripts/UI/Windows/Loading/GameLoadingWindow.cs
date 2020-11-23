using ProjectSpace.Constants;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectSpace.UI.Windows.Loading
{
    public class GameLoadingWindow : WindowBase
    {
        public const string prefabPath = @"Prefabs\UI\Windows\Loading\GameLoadingWindow";

        private string sceneName;


        public override void Initialize(object _data)
        {
            base.Initialize(_data);

            sceneName = (string)_data;

            var operation = SceneManager.LoadSceneAsync(sceneName);
            StartCoroutine(UpdateProgress(operation));
        }


        private IEnumerator UpdateProgress(AsyncOperation _operation)
        {
            if (_operation == null)
                yield break;

            while (!_operation.isDone)
            {
                Debug.LogError("Progress : " + _operation.progress);
                yield return null;
            }

            //yield return new WaitForSeconds(2.5f);

            Close();
        }
    }
}
