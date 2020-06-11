using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Zoo
{
    public class Wolverine : Animal
    {
        public void Start()
        {
            type = "Omnivoor";
            hasTrick = true;
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "Hello there";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            text.text = "Ugh i hate Leaves";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            text.text = "Meats back on the menu boys!!!";
        }
        public override void PerformTrick()
        {
            if (hasTrick = true)
            {
                StartCoroutine(DoTwril());
            }
        }
    }
}
