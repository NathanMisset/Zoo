using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Animal
    {
        public void Start()
        {
            type = "Carnivore";
            hasTrick = false;
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "rraaarww";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            text.text = "nomnomnom thx wubalubadubdub";
        }
    }
}
