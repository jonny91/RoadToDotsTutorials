// *************************************************************************************
//  *
//  * 文 件 名:   PieceColorComponent.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-09 0:57
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

namespace Boom
{
    [MaterialProperty("_BaseColor")]
    public struct PieceColorComponent : IComponentData
    {
        public float3 Color;
    }
}