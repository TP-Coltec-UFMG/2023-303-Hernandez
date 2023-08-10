using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvChannels : MonoBehaviour
{

    [SerializeField] GameObject redButton;
    [SerializeField] GameObject blueButton;
    [SerializeField] DisplayImage displayImage;
    [SerializeField] GameObject tvCrash;
    [SerializeField] GameObject secret;
    private float redRotation;
    private float blueRotation;

    // Update is called once per frame
    public void VerificaTV()
    {
        redRotation = this.redButton.transform.localRotation.eulerAngles.z;
        blueRotation = this.blueButton.transform.localRotation.eulerAngles.z;

        if((blueRotation > 295 && blueRotation < 310 || blueRotation > 115 && blueRotation < 130)&&(redRotation > 125 && redRotation < 145 || redRotation > 305 && redRotation < 325)){
            this.displayImage.TurnOffTV();
            this.tvCrash.SetActive(false);
            this.secret.SetActive(false);
            //ativa o gif certo
            Debug.Log("parabuains");
   
        } else if((blueRotation > 355 || blueRotation < 5 || blueRotation > 175 && blueRotation < 185)&&(redRotation > 220 && redRotation < 230 || redRotation > 40 && redRotation < 50)){
            this.displayImage.TurnOffTV();
            this.tvCrash.SetActive(false);
            this.secret.SetActive(true);
    
        } else{
            //pra impedir que algum engracadinho fique testando posicoes aleatorias
            this.blueButton.transform.eulerAngles = new Vector3(0, 0, 0);
            this.redButton.transform.eulerAngles = new Vector3(0, 0, 0);

                this.tvCrash.SetActive(true);
                this.secret.SetActive(false);
        }
    }
}
