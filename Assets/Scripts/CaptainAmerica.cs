using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Zoo
{
    public class CaptainAmerica : Animal
    {
        public void Start()
        {
            type = "Omnivoor";
            hasTrick = true;
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "General kenobi";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            text.text = "So .... you made a mistake..";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            text.text = "The strength of this country isn’t in buildings of brick and steel. It’s in the hearts of those who have sworn to fight for its freedom!";
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
