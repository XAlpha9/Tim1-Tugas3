using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.SaveData
{
    public class SaveController : DataController<SaveController, SaveModel, ISaveDataModel>
    {
        public float PlayerX { get; private set; }
        private void SaveData()
        {
            PlayerPrefs.SetFloat("PlayerX", _model.PlayerX);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            float playerX = PlayerPrefs.GetFloat("PlayerX");
            _model.SetPlayerXData(playerX);
        }
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnUpdatePlayerX(float playerX)
        {
            _model.SetPlayerXData(playerX);
            SaveData();
        }
    }
}

