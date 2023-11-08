// *************************************************************************************
//  *
//  * 文 件 名:   InputSystem.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 21:58
// *************************************************************************************

using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Boom
{
    [UpdateInGroup(typeof(BoomSystemGroup))]
    public partial class InputSystem : SystemBase
    {
        [BurstCompile]
        protected override void OnUpdate()
        {
            if (Input.GetMouseButtonDown(0))
            {
                // var queryBuilder = new EntityQueryBuilder(Allocator.Temp)
                //     .WithAll<PieceAspect, RefRW<BoomComponent>>().Build(this);
                var center = float3.zero;
                var count = 0;
                foreach (var (piece, boom) in SystemAPI.Query<PieceAspect, BoomComponent>())
                {
                    count++;
                    center += piece.Trans.ValueRO.Position;
                }
                
                foreach (var (piece, boom) in SystemAPI.Query<PieceAspect, RefRW<BoomComponent>>())
                {
                    boom.ValueRW.Boom = true;
                    boom.ValueRW.Center = center / count;
                    piece.Move.ValueRW.Velocity = math.normalize(piece.Trans.ValueRO.Position - boom.ValueRO.Center) *
                                                  boom.ValueRO.Intensity;
                }

                this.Enabled = false;
            }
        }
    }
}