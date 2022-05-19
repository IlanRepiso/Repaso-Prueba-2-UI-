using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject MyCube;
    
    // Start is called before the first frame update
    void Start()
    {
        MyCube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
