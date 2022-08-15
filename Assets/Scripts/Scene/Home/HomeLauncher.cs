using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using Tim1RX.SpaceInvader.Boot;
using UnityEngine;

namespace Tim1RX.SpaceInvader.Home
{
    public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
    {
        public override string SceneName => "Home";
        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }
        protected override ILoad GetLoader()
        {
            throw new System.NotImplementedException();
        }

        protected override IMain GetMain()
        {
            throw new System.NotImplementedException();
        }

        protected override IConnector[] GetSceneConnectors()
        {
            throw new System.NotImplementedException();
        }

        protected override IController[] GetSceneDependencies()
        {
            throw new System.NotImplementedException();
        }

        protected override ISplash GetSplash()
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerator InitSceneObject()
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerator LaunchScene()
        {
            throw new System.NotImplementedException();
        }
    }
}
