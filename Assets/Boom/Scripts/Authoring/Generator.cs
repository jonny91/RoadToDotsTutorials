// *************************************************************************************
//  *
//  * 文 件 名:   Generator.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-08 16:40
// *************************************************************************************

using Unity.Entities;
using UnityEngine;

namespace Boom
{
    public class Generator : MonoBehaviour
    {
        public GameObject PiecePrefab;
        public int Radio = 10;

        private class GeneratorBaker : Baker<Generator>
        {
            public override void Bake(Generator authoring)
            {
                var proto = GetEntity(authoring.PiecePrefab, TransformUsageFlags.Dynamic);
                var generator = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent(generator, new GeneratorComponent
                {
                    Proto = proto,
                    Radio = authoring.Radio,
                    Center = authoring.PiecePrefab.transform.position,
                });
            }
        }
    }
}