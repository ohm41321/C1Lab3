using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public GameObject prefab; 
    public int numberOfObjects; 
    public float radius; 
    void Start()
    {
        this.make_circle(); 
    }
    void Update()
    {
        
    }
  void make_circle()
{
    Debug.Log("make_circle method called.");
    float angle = 360f / numberOfObjects;
    for (int i = 0; i < numberOfObjects; i++)
    {
        float x = Mathf.Sin(Mathf.Deg2Rad * angle * i) * radius;
        float z = Mathf.Cos(Mathf.Deg2Rad * angle * i) * radius;
        Vector3 position = new Vector3(x, 0.5f, z);
        Debug.Log($"Instantiating prefab at position: {position}");
        Instantiate(prefab, position, Quaternion.identity);
    }
}

}
