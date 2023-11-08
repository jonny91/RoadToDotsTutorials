// *************************************************************************************
//  *
//  * 文 件 名:   GeneratorComponent.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 16:43
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;

namespace Boom
{
    public struct GeneratorComponent : IComponentData
    {
        public Entity Proto;
        public int Radio;
        public float3 Center;
        public float Intensity;
    }
}