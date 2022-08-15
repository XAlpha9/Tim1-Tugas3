using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterView : ObjectView<ICharacterModel>
    {
        protected KeyCode RightInput, LeftInput, ShootInput;

        protected override void InitRenderModel(ICharacterModel model)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(ICharacterModel model)
        {
            throw new System.NotImplementedException();
        }
    }

}
