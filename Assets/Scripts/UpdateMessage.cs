using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Message
{
    public struct UpdateMessage
    {
        //public float PlayerX { get; private set; }
        public bool Shoot { get; private set; }

        public UpdateMessage(bool shoot)
        {
            Shoot = shoot;
        }
        //public UpdateMessage(float playerX)
        //{
        //    PlayerX = playerX;
        //}
    }
}

