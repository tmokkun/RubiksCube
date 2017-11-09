using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class group : MonoBehaviour
{

    public Transform layer;
    public Transform sub_cube;
    public void findlayer(string name)
    {
        layer = transform.Find(name).transform;
    }

    public void layer_change(string parent_name, string child_name)
    {
        findlayer(parent_name);
        sub_cube = transform.Find(child_name).transform;
        sub_cube.SetParent(layer);
    }

}
