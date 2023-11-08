// *************************************************************************************
//  *
//  * 文 件 名:   StartBoomSystem.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 19:28
// *************************************************************************************

using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Boom
{
    [UpdateInGroup(typeof(BoomSystemGroup))]
    public partial class StartBoomSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var center = float3.zero;
                var count = 0;
                foreach (var pieceAspect in SystemAPI.Query<PieceAspect>())
                {
                    count++;
                    center += pieceAspect.Trans.ValueRO.Position;
                }

                center /= count;
            }
        }
    }
}