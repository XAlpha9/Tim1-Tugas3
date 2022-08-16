using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        float PlayerX { get; }

        //public event OnDataModified OnDataModified;
    }

}

