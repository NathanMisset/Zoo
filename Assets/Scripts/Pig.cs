using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Animal
    {
        public void Start()
        {
            type = "Omnivoor";
            hasTrick = true;
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "oink oink";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            text.text = "munch munch oink";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            text.text = "nomnomnom oink thx";
        }
    }
}
