using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationController : MonoBehaviour
{

    public GameObject amoebaPrefab;

    public MeshRenderer floorMeshRenderer;

    private GameObject amoebaOne;

    void Start()
    {
        amoebaOne = Instantiate(amoebaPrefab, new Vector3(0, 1.75f, 0), Quaternion.identity, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
