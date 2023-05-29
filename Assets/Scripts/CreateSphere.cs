using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateSphere : MonoBehaviour
{
    public GameObject prefab; //Sphere Prefab
    public GameObject SpawnSphere;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Sphere") == null) //si no se encuentra la esfera
        {
            //instanciar a la posición local del objeto vacío
            GameObject sphere = Instantiate(prefab, SpawnSphere.transform);
            sphere.name = "Sphere";
            sphere.transform.localPosition = Vector3.zero;
            sphere.transform.localRotation = Quaternion.identity;
        }
    }
}
