using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Animal
    {
        public void Start()
        {
            type = "Herbivore";
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "splash";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            text.text = "munch munch lovely";
        }
    }
    
}
