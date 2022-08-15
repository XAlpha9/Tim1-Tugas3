using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Boot;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterController : ObjectController<CharacterController, CharacterModel, ICharacterModel, CharacterView>
    {
        protected KeyCode RightInput { get; private set; }
        protected KeyCode LeftInput { get; private set; }
        protected KeyCode ShootInput { get; private set; }
        public float PlayerX { get; private set; }
        public GameObject Player { get; private set; }
        protected void OnCodeDown()
        {
            if (Input.GetKeyDown(RightInput))
            {
                PlayerX = Player.transform.position.x;
            }
        } 
    }
}

