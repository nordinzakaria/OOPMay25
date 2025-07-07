using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class MyMonster : MonoBehaviour, Shooter
    {
        [SerializeField] Bullet bullet;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            bullet = Instantiate(bullet, transform.position, transform.rotation );
            bullet.Init(new Vector3(-1, -1, 0));
        }
    }
}