using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Tim1RX.SpaceInvader.Module.Projectile;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterController : ObjectController<CharacterController, CharacterModel, ICharacterModel, CharacterView>
    {
        protected KeyCode RightInput { get; private set; }
        protected KeyCode LeftInput { get; private set; }
        protected KeyCode ShootInput { get; private set; }
        public float PlayerX { get; private set; }
        public GameObject Player { get; private set; }
        private ProjectileView ProjectileView;

        private void OnKeyLeft()
        {
            _model.SetX(PlayerX);
            _model.PlayerObject(Player);
            PlayerX = PlayerX - 0.025f;
            
            Debug.Log("The Controller Goes Left, X: " + PlayerX);
            //Publish<UpdateMessage>(new UpdateMessage(_model.PlayerX));
        }
        private void OnKeyRight()
        {
            _model.SetX(PlayerX);
            _model.PlayerObject(Player);
            PlayerX = PlayerX + 0.025f;
            Debug.Log("The Controller Goes Right, X: " + PlayerX);
            //Publish<UpdateMessage>(new UpdateMessage(_model.PlayerX));
        }
        private void OnKeyShoot()
        {
            ProjectileView.isShoot = true;
            Debug.Log("Pew Pew...Bang!");
            //Publish<UpdateMessage>(new UpdateMessage(_model.PlayerX));
        }

        public override void SetView(CharacterView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnKeyLeft, OnKeyRight, OnKeyShoot);
            Debug.Log("view Set!");
        }

        public override IEnumerator Finalize()
        {
            return null;
            //yield return base.Finalize();
            //_model.SetX(_SaveData.Model.PlayerX);
            //Debug.Log("Finallize.... Black Ace!");
        }
        
    }
}

