﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ET.Client
{
    [FriendOf(typeof(GlobalComponent))]
    [EntitySystemOf(typeof(DlgLobby))]
	public static partial class DlgLobbySystem
	{

		public static void Awake(this DlgLobby self)
		{
			
		}
		public static void Destroy(this DlgLobby self)
		{
			
		}
		public static void RegisterUIEvent(this DlgLobby self)
		{
		  self.View.E_EnterMapButton.AddListener(()=>
		  {
			  self.OnEnterMapClickHandler().Coroutine();
		  });
		  self.View.E_SoloButton.AddListener(()=>
		  {
			  self.OnSoloClickHandler().Coroutine();
		  });
		  self.View.E_BackToLoginButton.AddListener(()=>
		  {
			  self.OnBackToLoginHandler().Coroutine();
		  });
          
		
		}

		public static void ShowWindow(this DlgLobby self, ShowWindowDataBase contextData = null)
        {
            PlayerComponent playerComponent = self.Root().GetComponent<PlayerComponent>();
            if (playerComponent != null)
            {
                /*Player player = playerComponent.MyPlayer;
                if (player != null)
                {
                    self.View.E_PlayerNameText.text = player.PlayerName;
                    self.View.E_AvatarEUIImage.sprite = ResComponent.Instance.LoadAsset<Sprite>($"Avatar{player.AvatarIndex}");
                }*/
            }
        }
		
		public static async ETTask OnEnterMapClickHandler(this DlgLobby self)
        {
            // await EnterMapHelper.EnterMapAsync(self.DomainScene());
            self.Root().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Lobby);
            await EnterMapHelper.EnterMapAsync(self.Root());
		}
        
        /// <summary>
		/// 发起创建/加入房间请求
		/// </summary>
		/// <param name="self"></param>
		/// <returns></returns>
		public static async ETTask OnSoloClickHandler(this DlgLobby self)
        {
            // self.Root().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Room);
            EnterMapHelper.StateSyncMatch(self.Fiber()).Coroutine();
        }
		public static async ETTask OnBackToLoginHandler(this DlgLobby self)
        {

            Transform trans = GlobalComponent.Instance.Global;
            // Game.Close();
            MonoResComponent.Instance.Destroy();
            trans.gameObject.SetActive(false);
            UnityEngine.Object.DestroyImmediate(trans.gameObject);
            SceneManager.LoadSceneAsync($"Init");
        }
    }
}
