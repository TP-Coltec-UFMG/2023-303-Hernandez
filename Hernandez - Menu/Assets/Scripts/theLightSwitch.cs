using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theLightSwitch : MonoBehaviour
{
    [SerializeField] private GameObject up;
    [SerializeField] private GameObject down;
    [SerializeField] private GameObject on;

    public bool isOn;

    private void Start() {
        up.SetActive(isOn);
        down.SetActive(!isOn);
        on.SetActive(isOn);
    }

    public void OnSwitchChange()
    {
        isOn = !isOn;
        up.SetActive(isOn);
        down.SetActive(!isOn);
        on.SetActive(isOn);
    }
    

}
