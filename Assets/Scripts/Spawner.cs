using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using UnityEngine.UI;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;

        private Lion henk;
        private Hippo elsa;
        private Pig dora;
        private Tiger wally;
        private Zebra marty;

        [SerializeField]
        private GameObject inputField;

        private string name;

        private void Start()
        {
            henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.name = "henk";
            elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "elsa";
            dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "dora";
            wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "wally";
            marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "marty";
        }

        private void Update()
        {
            name = inputField.GetComponent<InputField>().text;
        }

        public void EatLeafsAll()
        {
            elsa.EatLeaves();
            dora.EatLeaves();
            marty.EatLeaves();
        }

        public void EatMeatAll()
        {
            henk.EatMeat();
            dora.EatMeat();
            wally.EatMeat();
        }
        public void DoATrickAll()
        {
            dora.PerformTrick();
            wally.PerformTrick();
        }
        public void SayHelloAll()
        {
            switch (name)
            {
                case "henk":
                case "lion":
                case "leeuw":
                    henk.SayHello();
                    break;
                case "else":
                case "hippo":
                case "nijlpaard":
                    elsa.SayHello();
                    break;
                case "dora":
                case "pig":
                case "varken":
                    dora.SayHello();
                    break;
                case "wally":
                case "tiger":
                case "tijger":
                    wally.SayHello();
                    break;
                case "marty":
                case "zebra":
                    marty.SayHello();
                    break;
                case "":
                    henk.SayHello();
                    elsa.SayHello();
                    dora.SayHello();
                    wally.SayHello();
                    marty.SayHello();
                    break;
                default:
                    break;
            }
            
        }

    }
}
