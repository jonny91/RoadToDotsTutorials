// *************************************************************************************
//  *
//  * 文 件 名:   PiecesGenerator.cs
//  * 描    述:
//  *
//  * 创 建 者：  洪金敏
//  * 创建时间：  2023-11-07 20:51
// *************************************************************************************

using Unity.Entities;
using UnityEngine;

namespace Boom
{
    public class PiecesGenerator : MonoBehaviour
    {
        [SerializeField]
        private GameObject PiecePrefab;

        /// <summary>
        /// 半径
        /// </summary>
        [SerializeField]
        private int Radius = 10;

        private class PiecesGeneratorBaker : Baker<PiecesGenerator>
        {
            public override void Bake(PiecesGenerator authoring)
            {
                var generateEntity = GetEntity(TransformUsageFlags.Dynamic);
                
            }
        }
    }
}