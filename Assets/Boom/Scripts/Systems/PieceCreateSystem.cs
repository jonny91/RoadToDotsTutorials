// *************************************************************************************
//  *
//  * 文 件 名:   PieceCreateSystem.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 16:08
// *************************************************************************************

using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Boom.Systems
{
    [RequireMatchingQueriesForUpdate]
    [UpdateInGroup(typeof(BoomSystemGroup))]
    public partial struct PieceCreateSystem : ISystem, ISystemStartStop
    {
        public void OnStartRunning(ref SystemState state)
        {
            var generatorComponent = SystemAPI.GetSingleton<GeneratorComponent>();
            var shape = new ParentShapeComponent
            {
                Center = generatorComponent.Center,
            };

            var radio = generatorComponent.Radio;
            var proto = generatorComponent.Proto;
            for (var x = -radio; x <= radio; x++)
            {
                for (var z = -radio; z <= radio; z++)
                {
                    for (var y = -radio; y <= radio; y++)
                    {
                        if (math.distance(new float3(x, y, z), shape.Center) >= radio)
                        {
                            continue;
                        }

                        var piece = state.EntityManager.Instantiate(proto);
                        state.EntityManager.SetComponentData(piece, new LocalTransform()
                        {
                            Position = new float3(x, y, z),
                            Rotation = quaternion.identity,
                            Scale = .9f,
                        });
                        state.EntityManager.AddComponentData(piece, new MoveComponent());
                        state.EntityManager.AddComponentData(piece, new BoomComponent()
                        {
                            Boom = false,
                            Center = float3.zero,
                            Intensity = generatorComponent.Intensity,
                        });
                        state.EntityManager.AddComponentData(piece, new PieceColorComponent());
                        state.EntityManager.AddSharedComponent(piece, shape);
                    }
                }
            }
        }

        public void OnStopRunning(ref SystemState state)
        {
        }

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<GeneratorComponent>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }
    }
}