// *************************************************************************************
//  *
//  * 文 件 名:   AssetsReferences.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 15:59
// *************************************************************************************

using System;
using Unity.Entities;
using Unity.Entities.Content;
using Unity.Entities.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Boom
{
    [Serializable]
    public struct AssetsReferences : IComponentData
    {
        public bool StartedLoad;
        public EntityPrefabReference EntityPrefabReference;
        public WeakObjectReference<GameObject> GameObjectPrefabReference;
    }
}