
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public LightPanel lightPanel; 
    static int verifica;
    private bool taCerto = false;
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
            if(!taCerto){
                taCerto = true;
                lightPanel.verifica++;
                Debug.Log(lightPanel.verifica);
            }
            return true;
        }
        //Caso os switchs não estejam mais ligados :(
        if(taCerto){
            taCerto = false;
            lightPanel.verifica--;
            Debug.Log(lightPanel.verifica);
        }
        return false;
    }
}
