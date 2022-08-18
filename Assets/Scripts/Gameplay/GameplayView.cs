using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Module.Character;

namespace Tim1RX.SpaceInvader.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public CharacterView CharacterView;
    }

}

