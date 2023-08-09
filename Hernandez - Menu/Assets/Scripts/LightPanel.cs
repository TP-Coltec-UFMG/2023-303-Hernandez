using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanel : MonoBehaviour
{
    [SerializeField] private theLightSwitch lightSwitch_1;
    [SerializeField] private theLightSwitch lightSwitch_2;
    [SerializeField] private theLightSwitch lightSwitch_3;
    [SerializeField] private theLightSwitch lightSwitch_4;
    [SerializeField] private theLightSwitch lightSwitch_5;
    
    void Update()
    {
        VerificaLigar();
    }

    public bool VerificaLigar()
    {
        if ((lightSwitch_1.isOn == true) && (lightSwitch_2.isOn == true) && (lightSwitch_3.isOn == true) && (lightSwitch_4.isOn == true) && (lightSwitch_5.isOn == true))
        {
            return true;
        }
        return false;
    }
}
