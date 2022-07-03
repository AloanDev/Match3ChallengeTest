using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class PieceTypeDatabase : MonoBehaviour
    {
        [SerializeField] private List<Sprite> spritesPerPieceTypeId;

        public Sprite GetSpriteForPieceType(int pieceType)
        {
            if (pieceType >= 0 && pieceType < spritesPerPieceTypeId.Count)
            {
                return spritesPerPieceTypeId[pieceType];
            }

            return null;
        }
    }
}