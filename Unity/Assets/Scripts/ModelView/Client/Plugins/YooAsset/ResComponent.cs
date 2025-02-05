using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using YooAsset;

namespace ET.Client
{
    [ComponentOf(typeof(Scene))]
    public class ResComponent: Entity, IAwake, IDestroy, IUpdate
    {
        [StaticField]
        public static ResComponent Instance { get; set; }

        public string PackageVersion { get; set; }

        public ResourceDownloaderOperation Downloader { get; set; }
        
        public Dictionary<string, AssetOperationHandle> AssetsOperationHandles = new Dictionary<string, AssetOperationHandle>(100);
        
        public Dictionary<string, SubAssetsOperationHandle> SubAssetsOperationHandles = new Dictionary<string, SubAssetsOperationHandle>();
        
        public Dictionary<string, SceneOperationHandle> SceneOperationHandles = new Dictionary<string, SceneOperationHandle>();
        
        public Dictionary<string, RawFileOperationHandle> RawFileOperationHandles = new Dictionary<string, RawFileOperationHandle>(100);

        public Dictionary<OperationHandleBase, Action<float>> HandleProgresses = new Dictionary<OperationHandleBase, Action<float>>();

        public Queue<OperationHandleBase> DoneHandleQueue = new Queue<OperationHandleBase>();
    }
}