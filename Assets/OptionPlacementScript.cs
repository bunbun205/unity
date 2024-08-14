using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OptionPlacementScript : MonoBehaviour

{

    public List <GameObject> placements;
    public GameObject OptionMesh;
    // Start is called before the first frame update
    void Start()
    {
       foreach (GameObject placement in placements){
        placement.transform.Rotate (new Vector3 (-90, 0, 0));
        GameObject newOption = GameObject.Instantiate (OptionMesh);
        newOption.transform.position = placement.transform.position;
        newOption.transform.rotation = placement.transform.rotation;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
