using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanel : MonoBehaviour
{
    public int verifica = 0;

    // Update is called once per frame
    void Update()
    {
        Actions.OnStoryAdvanced(1);
    }
}
