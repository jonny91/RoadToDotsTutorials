// *************************************************************************************
//  *
//  * 文 件 名:   PiecesGenerator.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-07 20:51
// *************************************************************************************

using Unity.Entities;
using Unity.Rendering;
using UnityEngine;

namespace Boom
{
    public class AssetsAuthoring : MonoBehaviour
    {
        [SerializeField]
        public AssetsReferences AssetsReferences;

        private class AssetsBaker : Baker<AssetsAuthoring>
        {
            public override void Bake(AssetsAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                AddComponent(entity, authoring.AssetsReferences);
            }
        }
    }
}