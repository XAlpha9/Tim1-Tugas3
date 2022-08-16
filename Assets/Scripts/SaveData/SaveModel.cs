using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.SaveData
{
    public class SaveModel : BaseModel, ISaveDataModel
    {
        public float PlayerX { get; private set; }
        public void SetPlayerXData(float playerX)
        {
            PlayerX = playerX;
            SetDataAsDirty();
        }
    }
}


