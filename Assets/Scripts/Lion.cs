using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Animal
    {
        public void Start()
        {
            type = "Carnivore";
        }
        public override void SayHello()
        {
            base.SayHello();
            text.text = "roooaoaaaaar";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            text.text = "nomnomnom thx mate";
        }
    }
}
