using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcodes1 : MonoBehaviour
{
    string heroname = "miao";
    int heroHeight = 27;
    float heroAge = 2.5f;
    string heroSuperPower = "speed";
    int heroheightafter = 185 + 5;
    string villainName = "hwhw";
    int vililanHeight = 20;
    int villainAge = 3;
    string villainSuperPower = "boxing";
    string villainSuperPowerafter = "None";



    // Start is called before the first frame update
    void Start()
    {
        print("hero name is" + heroname + "hero height is" + heroHeight + "hero age is" + heroAge + "hero superpower is" + heroSuperPower);
        print("villain Name is" + villainName + " vililan Height is" + vililanHeight + "villain Age is" + villainAge + "villain SuperPower is" + villainSuperPower);
        print("Age differnce" + (heroAge - villainAge));
        print("hero height after is" + heroheightafter);
        print("villain SuperPower after is" + villainSuperPowerafter);

    }

    // Update is called once per frame
    void Update()
    {

    }
}