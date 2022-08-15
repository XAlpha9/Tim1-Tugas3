using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterModel : BaseModel, ICharacterModel
    {
        public GameObject Player => GameObject.Find("Player");

        public float PlayerX { get; private set; }

        public void SetX(float playerX)
        {
            PlayerX = playerX;
            SetDataAsDirty();
        }
        
    }

}
