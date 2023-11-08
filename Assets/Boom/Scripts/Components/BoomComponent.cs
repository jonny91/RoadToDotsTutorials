// *************************************************************************************
//  *
//  * 文 件 名:   BoomComponent.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 23:06
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;

namespace Boom
{
    public struct BoomComponent : IComponentData
    {
        public bool Boom;
        public float3 Center;
        //强度
        public float Intensity;
    }
}