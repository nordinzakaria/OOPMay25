using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public abstract class BaseCtrl : MonoBehaviour
    {
        protected Rigidbody2D RBody { get; set; }

        protected void Start()
        {
            RBody = GetComponent<Rigidbody2D>();
        }

        public abstract void Move();
    }
}