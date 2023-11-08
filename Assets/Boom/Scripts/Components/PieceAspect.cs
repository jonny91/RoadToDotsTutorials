// *************************************************************************************
//  *
//  * 文 件 名:   PieceAspect.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 19:41
// *************************************************************************************

using Unity.Entities;
using Unity.Transforms;

namespace Boom
{
    public readonly partial struct PieceAspect : IAspect
    {
        public readonly RefRW<MoveComponent> Move;
        public readonly RefRW<LocalTransform> Trans;
    }
}