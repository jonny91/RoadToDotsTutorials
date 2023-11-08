// *************************************************************************************
//  *
//  * 文 件 名:   StartBoomSystem.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 19:28
// *************************************************************************************

using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Boom
{
    [RequireMatchingQueriesForUpdate]
    [UpdateInGroup(typeof(BoomSystemGroup))]
    public partial struct BoomSystem : ISystem
    {
        private EntityQuery _boomEntityQuery;

        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<BoomComponent>();

            var queryBuilder = new EntityQueryBuilder(Allocator.Temp)
                .WithAll<BoomComponent>();
            _boomEntityQuery = state.GetEntityQuery(queryBuilder);
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var job = new BoomJob
            {
                ElapsedTime = (float)SystemAPI.Time.ElapsedTime,
            };
            state.Dependency = job.ScheduleParallel(state.Dependency);
        }
    }
}