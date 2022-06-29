using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GroundMVC;

namespace GroundMVC
{
    public class GroundView : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        [HideInInspector] public GameObject destroyer;
        private GroundController groundController;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject == destroyer)
            {
                Destroy(this.gameObject);
            }
        }
        public void SetController(GroundController groundController)
        {
            this.groundController = groundController;
        }
    }
}
