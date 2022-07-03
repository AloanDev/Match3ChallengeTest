using UnityEngine;

namespace Views {
    
    [RequireComponent(typeof(SpriteRenderer))]
    public class VisualPiece : MonoBehaviour {

        public void SetSprite(Sprite sprite) {
            var spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
        
    }
}