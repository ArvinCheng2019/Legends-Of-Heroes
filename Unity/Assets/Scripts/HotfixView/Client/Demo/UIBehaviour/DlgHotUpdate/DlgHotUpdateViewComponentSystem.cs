﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[FriendOf(typeof(DlgHotUpdateViewComponent))]
	[EntitySystemOf(typeof(DlgHotUpdateViewComponent))]
	public static partial class DlgHotUpdateViewComponentSystem
	{
		[EntitySystem]
		public static void Awake(this DlgHotUpdateViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
		[EntitySystem]
		public static void Destroy(this DlgHotUpdateViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
