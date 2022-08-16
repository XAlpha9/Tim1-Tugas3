using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Module.Character;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterModel : BaseModel, ICharacterModel
    {
        public float PlayerX { get; private set; }

        public void SetX(float playerX)
        {
            PlayerX = playerX;
            Debug.Log("x: " + PlayerX);
            SetDataAsDirty();
        }
        
    }

}