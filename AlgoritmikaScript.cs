using System;
using UnityEngine;

public class AlgoritmikaScript : MonoBehaviour
{
    [SerializeField] private GameObject destroyObject;

    void Start()
    {
        if(destroyObject != null)
            Destroy(destroyObject);
        else
            throw new Exception("None destroy object");

    }

    void Update()
    {
        Debug.Log("crickets");
    }
}
