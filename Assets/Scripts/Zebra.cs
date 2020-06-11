using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal
    {
        public void Start()
        {
            type = "Herbivore";
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "zebra zebra";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            text.text = "munch munch zank yee bra";
        }
    }
}
