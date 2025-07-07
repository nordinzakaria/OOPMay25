using UnityEngine;

namespace Assets.Scripts
{

    public class CharCtrl : BaseCtrl
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        protected void Update()
        {
            if (Input.GetKeyUp(KeyCode.W))
            {
                Move();
            }
        }


        public override void Move()
        {
            RBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            RBody.linearVelocity = new Vector2(1, 0);
        }

    }
}