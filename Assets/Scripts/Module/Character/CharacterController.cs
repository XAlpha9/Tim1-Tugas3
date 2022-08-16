using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Boot;
using Tim1RX.SpaceInvader.Module.Character;
using Tim1RX.SpaceInvader.Message;

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
            Debug.Log("tombol kepencet");
            if (Input.GetKeyDown(RightInput))
            {
                Debug.Log("Tombol masuk");
                PlayerX = Player.transform.position.x;
            }
        } 
    }
}

