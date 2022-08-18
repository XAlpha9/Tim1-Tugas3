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
        public GameObject Player { get; private set; }
        public float PlayerX { get; private set; }
        public KeyCode RightInput { get; private set; }
        public KeyCode LeftInput { get; private set; }
        public KeyCode ShootInput { get; private set; }

        public void SetX(float playerX)
        {
            PlayerX = playerX;
            SetDataAsDirty();
            Debug.Log("x: " + PlayerX);
        }

        public void PlayerObject(GameObject player)
        {
            Player = player;
            SetDataAsDirty();
        }

        //public void GoLeft()
        //{
        //    PlayerX;
        //    SetDataAsDirty();
        //    Debug.Log("The player goes right");
        //}
        //public void GoRight()
        //{
        //    PlayerX;
        //    SetDataAsDirty();
        //    Debug.Log("The player goes right");
        //}
        //public void Shoot()
        //{
        //    Debug.Log("The player Shoot!!!");
        //    SetDataAsDirty();
        //}

    }

}
