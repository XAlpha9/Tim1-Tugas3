using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Message;
using Tim1RX.SpaceInvader.SaveData;

namespace Tim1RX.SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveController _saveData;
        public void OnUpdatePlayerX(UpdateMessage message)
        {
            //_saveData.OnUpdatePlayerX(message.PlayerX);
        }
        protected override void Connect()
        {
            Subscribe<UpdateMessage>(OnUpdatePlayerX);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateMessage>(OnUpdatePlayerX);
        }
    }
}

