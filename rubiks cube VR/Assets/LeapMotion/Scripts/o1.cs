using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class o1 : MonoBehaviour
{
    
    public string[] layerelemnt;
    public group group1;
    Transform sub_cube;
    Transform del_cube;
    //set here not in start so that tohe class canuse this attribute
   public List<string>  layer_del;
   
    void Start()
    {
        
        group1 = this.gameObject.AddComponent<group>();
        layer_del = new List<string>();



        layerelemnt = new string[21];


        layerelemnt[0] = "Cube.001";
        layerelemnt[1] = "Cube.002";
        layerelemnt[2] = "Cube.003";
        layerelemnt[3] = "Cube.004";
        layerelemnt[4] = "Cube.024";
        layerelemnt[5] = "Cube.006";
        layerelemnt[6] = "Cube.007";
        layerelemnt[7] = "Cube.008";





        layerelemnt[8] = "Cube.009";
        layerelemnt[9] = "Cube.010";
        layerelemnt[10] = "Cube.026";
        layerelemnt[11] = "Cube.012";
        layerelemnt[12] = "Cube.026";
        layerelemnt[13] = "Cube.023";
        layerelemnt[14] = "Cube.015";
        layerelemnt[15] = "Cube.025";







        layerelemnt[16] = "Cube.017";
        layerelemnt[17] = "Cube.018";
        layerelemnt[18] = "Cube.019";
        layerelemnt[19] = "Cube.020";
        layerelemnt[20] = "Cube.021";
;
        
        



    






    }
    public void setlayer(string layer, string[] layerelemnt)
    {
        for (int i = 0; i <= layerelemnt.Length-1; i++)
        {
          
            Debug.Log(layer);
            sub_cube = GameObject.Find(layerelemnt[i]).transform;

            if (Vector3.Distance(sub_cube.position, this.transform.position) < 1.8)
            {
                layer_del.Add(layerelemnt[i]);
                group1.layer_change(layerelemnt[i]);
            }
        }
    }

    public  void clearlist()
    {
        for (int i = 0; i < layer_del.Count; i++)
        {
            del_cube = GameObject.Find(layer_del[i]).transform;

            del_cube.SetParent(transform.parent);
            layer_del.Remove(layer_del[i]);
        }

    }
    // Update is called once per frame
    void Update()
    {



    }
}