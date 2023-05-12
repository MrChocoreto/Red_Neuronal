using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuronas : MonoBehaviour{


    #region Variables


    [Header("PreLoad_Data")]
    [SerializeField] float peso1, peso2, umbral;
    [SerializeField]Neuronas n;
    //AND E1 E2
    //1   1   1
    //0   1   0
    //0   0   1
    //0   0   0

    bool sw = false;




    #endregion



    #region Unity_Methods


    [ContextMenu("Prellenado")]
    void Awake(){

       
    }


        int con;
    [ContextMenu("Calculo_Neurona")]
    void Start(){
        while (!sw)
        { 
            sw = true;

            peso1 =  Random.Range(-1f,2f);
            peso2 =  Random.Range(-1f,2f);
            umbral =  Random.Range(-1f,2f);


            Debug.Log("-----------------------------------");
            Debug.Log("-----------------------------------");
            Debug.Log("peso1: "+peso1);
            Debug.Log("peso2: "+peso2);
            Debug.Log("umbral: "+umbral);
            Debug.Log("E1:1 E2:1 : " + n.funtion(n.Neurona(1f, 1f, peso1, peso2, umbral)));
            Debug.Log("E1:1 E2:0 : " + n.funtion(n.Neurona(1f, 0f, peso1, peso2, umbral)));
            Debug.Log("E1:0 E2:1 : " + n.funtion(n.Neurona(0f, 1f, peso1, peso2, umbral)));
            Debug.Log("E1:0 E2:0 : " + n.funtion(n.Neurona(0f, 0f, peso1, peso2, umbral)));
            //Debug.Log("-----------------------------------");

            con += 1;

            if (n.funtion(n.Neurona(1f,1f,peso1,peso2,umbral)) != 1)
            {
                //Debug.Log("E1:1 E2:1 : "+ n.funtion(n.Neurona(1f, 1f, peso1, peso2, umbral)));
                sw=false;
            }
            if (n.funtion(n.Neurona(1f, 0f, peso1, peso2, umbral)) != 0)
            {
                //Debug.Log("E1:1 E2:0 : " + n.funtion(n.Neurona(1f, 0f, peso1, peso2, umbral)));
                sw = false;
            }
            if (n.funtion(n.Neurona(0f, 1f, peso1, peso2, umbral)) != 0)
            {
                //Debug.Log("E1:0 E2:1 : " + n.funtion(n.Neurona(0f, 1f, peso1, peso2, umbral)));
                sw = false;
            }
            if (n.funtion(n.Neurona(0f, 0f, peso1, peso2, umbral)) != 0)
            {
                //Debug.Log("E1:0 E2:0 : " + n.funtion(n.Neurona(0f, 0f, peso1, peso2, umbral)));
                sw = false;
            }

        }
        Debug.Log("Vueltas: " + con);
        

    }
    

    float Neurona(float entra1, float entra2, float peso1, float peso2, float umbral)
    {
        return umbral + entra1 * peso1 + entra2 * peso2;
    }


    float funtion(float d)
    {
        return d > 0 ? 1 : 0;
    }

    void Update(){
        
    }


    #endregion


}



#region Clases_Extra

[System.Serializable]
class Capa
{
    public int hola;
    public string no;
}

[System.Serializable]
class Perceptron
{

}


[System.Serializable]
class Neuron
{

}

#endregion