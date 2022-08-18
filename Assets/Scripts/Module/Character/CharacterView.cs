using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace Tim1RX.SpaceInvader.Module.Character
{
    public class CharacterView : ObjectView<ICharacterModel>
    {
        [SerializeField]
        private KeyCode RightInput, LeftInput, ShootInput;
        [SerializeField]
        private GameObject Player;
        private UnityAction _OnKeyLeft, _OnkeyRight, _OnKeyShoot;

        public void SetCallbacks(UnityAction OnKeyLeft, UnityAction OnKeyRight, UnityAction OnKeyShoot)
        {
            _OnKeyLeft = OnKeyLeft;
            _OnkeyRight = OnKeyRight;
            _OnKeyShoot = OnKeyShoot;
            Debug.Log("Who Called Back!");
        }

        protected override void InitRenderModel(ICharacterModel model)
        {
            Player.transform.SetPositionAndRotation(new Vector2(_model.PlayerX, -4.25f), new Quaternion (0, 0, 180, 0));
            //Player.transform.Translate(new Vector2(_model.PlayerX, 0), Space.Self);
            Debug.Log("Char Position Init: " + _model.PlayerX);
        }

        protected override void UpdateRenderModel(ICharacterModel model)
        {
            Player.transform.SetPositionAndRotation(new Vector2(_model.PlayerX, -4.25f), new Quaternion(0, 0, 180, 0));
            //Player.transform.Translate(new Vector2(_model.PlayerX, 0), Space.Self);
            Debug.Log("Char Position Update: " + _model.PlayerX);
        }

        void Update()
        {
            if (Input.GetKey(RightInput))
            {
                _OnkeyRight?.Invoke();
                Debug.Log("Goes to Right :)");
            }

            if (Input.GetKey(LeftInput))
            {
                _OnKeyLeft?.Invoke();
                Debug.Log("Goes to Left :)");
            }
            
            if (Input.GetKeyDown(ShootInput))
            {
                _OnKeyShoot?.Invoke();
                Debug.Log("Goes Bang :)");
            }
        }


    }

}
