using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanel : MonoBehaviour
{
    [SerializeField] private theLightSwitch lightSwitch_1;
    [SerializeField] private theLightSwitch lightSwitch_2;
    [SerializeField] private theLightSwitch lightSwitch_3;
    [SerializeField] private theLightSwitch lightSwitch_4;

    private bool switchOK = false;
    void Update()
    {
        VerificaLigar();
    }

    public void VerificaLigar()
    {
        if ((lightSwitch_1.isOn == true) && (lightSwitch_2.isOn == true) && (lightSwitch_3.isOn == true) && (lightSwitch_4.isOn == true))
        {
            switchOK = true;
        }
    }
}
