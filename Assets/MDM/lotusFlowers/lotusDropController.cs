using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lotusDropController : MonoBehaviour
{
    public GameObject lotusPackage;
    public int dropRate = 4;

	void Start ()
    {
        InvokeRepeating("dropLotusPackage", 0, dropRate);
	}
	
	void dropLotusPackage ()
    {
        Instantiate(lotusPackage, transform.position, transform.rotation, null);
	}
}
