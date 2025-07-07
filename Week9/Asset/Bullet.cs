using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour
    {
        Vector3 velocity;
        //float angle = 0;

        // Use this for initialization
        void Start()
        {
        }

        public void Init(Vector3 vel)
        {
            velocity = vel;
            transform.up = vel;
        }

        // Update is called once per frame
        void Update()
        {
            //transform.Translate(velocity * Time.deltaTime);
            transform.position += (Vector3)velocity * Time.deltaTime;
            //transform.localRotation = Quaternion.Euler(0, 0, angle);
            //angle++;


            Debug.Log("Bullet moved by " + velocity + ", now at " + transform.position);
        }
    }
}