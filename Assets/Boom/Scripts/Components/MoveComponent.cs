// *************************************************************************************
//  *
//  * 文 件 名:   MoveComponent.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 19:24
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;

namespace Boom
{
    public struct MoveComponent : IComponentData
    {
        public float3 Velocity;
    }
}