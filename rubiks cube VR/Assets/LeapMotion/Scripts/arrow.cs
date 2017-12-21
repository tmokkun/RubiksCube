using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {
    public Material[] material;
    Renderer rend;
    int selectcolour;
   
    public int[] steplist;
    private void Start()
    {

        rend = GetComponent<MeshRenderer>();
        rend.enabled =true;
       


    }
    private void Update()
    {
        if (steplist[arrow_manager.looptime] == 3)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
            rend.sharedMaterial = material[steplist[arrow_manager.looptime]];
        }
    }

}
	
	

