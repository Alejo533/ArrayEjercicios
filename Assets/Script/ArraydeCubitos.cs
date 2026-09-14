using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraydeCubitos : MonoBehaviour
{
    public GameObject[] cubitos;
    // Start is called before the first frame update
    void Start()
    {
        DesactivarTodosLosElementos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DesactivarTodosLosElementos(){
        for (int i = 0; i<cubitos.Length; i++){
            cubitos[i].SetActive(false);
        }
    }
}
