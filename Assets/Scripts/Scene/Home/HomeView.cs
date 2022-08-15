using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Boot;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Tim1RX.SpaceInvader.Home
{
	public class HomeView : BaseSceneView
	{
		[SerializeField]
		private Button _playButton;
		//public void SetCallbacks(UnityAction onClickPlayButton)
		//{
		//	_playButton.onClick.RemoveAllListeners();
		//	_playButton.onClick.AddListener(onClickPlayButton);
		//}
	}
}
