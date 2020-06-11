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
        private GameObject lion, hippo, pig, tiger, zebra, captainAmerica, wolverine;

        private Lion henk;
        private Hippo elsa;
        private Pig dora;
        private Tiger wally;
        private Zebra marty;
        private CaptainAmerica steven;
        private Wolverine logan;

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
            steven = Instantiate(captainAmerica, transform).GetComponent<CaptainAmerica>();
            steven.name = "steven";
            logan = Instantiate(wolverine, transform).GetComponent<Wolverine>();
            logan.name = "logan";
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
            steven.EatLeaves();
            logan.EatLeaves();
        }

        public void EatMeatAll()
        {
            henk.EatMeat();
            dora.EatMeat();
            wally.EatMeat();
            steven.EatMeat();
            logan.EatMeat();
        }
        public void DoATrickAll()
        {
            dora.PerformTrick();
            wally.PerformTrick();
            steven.PerformTrick();
            logan.PerformTrick(); ;
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
                case "captain america":
                case "steven":
                    steven.SayHello();
                    break;
                case "wolverin":
                case "logan":
                    logan.SayHello();
                    break;
                case "":
                    henk.SayHello();
                    elsa.SayHello();
                    dora.SayHello();
                    wally.SayHello();
                    marty.SayHello();
                    logan.SayHello();
                    steven.SayHello();
                    break;
                default:
                    break;
            }
            
        }

    }
}
