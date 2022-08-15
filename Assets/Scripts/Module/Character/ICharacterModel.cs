using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public interface ICharacterModel : IBaseModel
    {
        public GameObject Player { get; }
        public float PlayerX { get; }
    }
}

