// *************************************************************************************
//  *
//  * 文 件 名:   ParentShapeComponent.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 19:50
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;

namespace Boom
{
    public struct ParentShapeComponent : IComponentData
    {
        public float3 Center;
        public float3 Bound;
    }
}