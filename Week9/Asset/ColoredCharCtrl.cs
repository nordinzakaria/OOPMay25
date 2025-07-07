using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ColoredCharCtrl : CharCtrl
    {

        // Use this for initialization
        protected void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        void Update()
        {
            base.Update();

            if (Input.GetKeyUp(KeyCode.S))
            {
                TurnRed();
            }
        }

        protected void TurnRed()
        {
                                                       // red is a *static* attribute 
            GetComponent<Renderer>().material.color = Color.red;
        }



    }
}