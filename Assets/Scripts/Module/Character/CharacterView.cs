using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Module.Character;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterView : ObjectView<ICharacterModel>
    {
        [SerializeField]
        private KeyCode RightInput, LeftInput, ShootInput;
        [SerializeField]
        private GameObject Player;
        private float playerX;

        protected override void InitRenderModel(ICharacterModel model)
        {
            playerX = model.PlayerX;
        }

        protected override void UpdateRenderModel(ICharacterModel model)
        {
            playerX = model.PlayerX;
        }
    }

}
