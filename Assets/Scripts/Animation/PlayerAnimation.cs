using System;
using UnityEngine;

namespace Animation
{
    public class PlayerAnimation : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        public Animator animator;
        public Rigidbody2D rb;

        private void Update()
        {
            if (rb.velocity.x < 0) spriteRenderer.flipX = true;
            else if (rb.velocity.x > 0) spriteRenderer.flipX = false;
            
            float direction = 0f;

            if (rb.velocity.x != 0 || rb.velocity.y != 0)
                direction = 1f;
            else
                direction = 0f;
            
            animator.SetFloat("direction", direction);
        }
    }
}