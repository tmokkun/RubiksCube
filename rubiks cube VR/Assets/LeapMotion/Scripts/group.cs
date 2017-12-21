using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class group : MonoBehaviour
{

   // public Transform layer;
    public Transform sub_cube;
    //public void findlayer(string name)
    //{
    //    layer = transform;
    //}

    public void layer_change(string child_name)
    {
        Debug.Log("a");
        // findlayer(parent_name);
        // sub_cube = transform.parent.Find(child_name).transform; if a belongs b ,b belongs c ,c can't find a
        sub_cube =GameObject.Find(child_name).transform;
        sub_cube.SetParent(transform);

    }

}
