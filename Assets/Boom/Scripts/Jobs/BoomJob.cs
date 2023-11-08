// *************************************************************************************
//  *
//  * 文 件 名:   BoomJob.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 23:04
// *************************************************************************************

using Unity.Burst;
using Unity.Collections;
using Unity.Entities;

namespace Boom
{
    [BurstCompile]
    public partial struct BoomJob : IJobEntity
    {
        public float ElapsedTime;

        public void Execute(in BoomComponent boom, PieceAspect piece, ref PieceColorComponent colorComponent)
        {
            if (!boom.Boom)
            {
                return;
            }

            piece.Trans.ValueRW.Position += piece.Move.ValueRO.Velocity * ElapsedTime;
            colorComponent.Color = piece.Trans.ValueRW.Position / 10;
        }
    }
}