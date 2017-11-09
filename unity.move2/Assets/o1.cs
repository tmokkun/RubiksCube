using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class o1 : MonoBehaviour {
    
    public string layer;
   public  string[] layerelemnt;
    group group1;
    // Use this for initialization
    void Start() {
        string[] abc = new string[27];
        abc[0] = "Cube";
        abc[1] = "Cube.001";
        abc[2] = "Cube.002";
        abc[3] = "Cube.003";
        abc[4] = "Cube.004";
        abc[5] = "Cube.005";
        abc[6] = "Cube.006";
        abc[7] = "Cube.007";
        abc[8] = "Cube.008";
        abc[9] = "Cube.009";
        abc[10] = "Cube.010";
        abc[11] = "Cube.011";
        abc[12] = "Cube.012";
        abc[13] = "Cube.013";
        abc[14] = "Cube.014";
        abc[15] = "Cube.015";
        abc[16] = "Cube.016";
        abc[17] = "Cube.017";
        abc[18] = "Cube.018";
        abc[19] = "Cube.019";
        abc[20] = "Cube.020";
        abc[21] = "Cube.021";
        abc[22] = "Cube.022";
        abc[23] = "Cube.023";
        abc[24] = "Cube.024";
        abc[25] = "Cube.025";
        abc[26] = "Cube.026";



        string[] layer_x1 = new string[9];
        layer_x1[0] = "Cube.001";
        layer_x1[1] = "Cube.004";
        layer_x1[2] = "Cube.007";
        layer_x1[3] = "Cube.010";
        layer_x1[4] = "Cube.013";
        layer_x1[5] = "Cube.016";
        layer_x1[6] = "Cube.019";
        layer_x1[7] = "Cube.022";
        layer_x1[8] = "Cube.025";



        string[] layer_x2 = new string[9];

        layer_x2[0] = "Cube";
        layer_x2[1] = "Cube.005";
        layer_x2[2] = "Cube.006";
        layer_x2[3] = "Cube.011";
        layer_x2[4] = "Cube.012";
        layer_x2[5] = "Cube.017";
        layer_x2[6] = "Cube.018";
        layer_x2[7] = "Cube.023";
        layer_x2[8] = "Cube.024";



        string[] layer_x3 = new string[9];
        layer_x3[0] = "Cube.002";
        layer_x3[1] = "Cube.003";
        layer_x3[2] = "Cube.008";
        layer_x3[3] = "Cube.009";
        layer_x3[4] = "Cube.014";
        layer_x3[5] = "Cube.015";
        layer_x3[6] = "Cube.020";
        layer_x3[7] = "Cube.021";
        layer_x3[8] = "Cube.026";


        string[] layer_y1 = new string[9];
        layer_y1[0] = "Cube.006";
        layer_y1[1] = "Cube.007";
        layer_y1[2] = "Cube.008";
        layer_y1[3] = "Cube.009";
        layer_y1[4] = "Cube.010";
        layer_y1[5] = "Cube.011";
        layer_y1[6] = "Cube.024";
        layer_y1[7] = "Cube.025";
        layer_y1[8] = "Cube.026";

        string[] layer_y2 = new string[9];
        layer_y2[0] = "Cube.003";
        layer_y2[1] = "Cube.004";
        layer_y2[2] = "Cube.005";
        layer_y2[3] = "Cube.012";
        layer_y2[4] = "Cube.013";
        layer_y2[5] = "Cube.014";
        layer_y2[6] = "Cube.021";
        layer_y2[7] = "Cube.022";
        layer_y2[8] = "Cube.023";

        string[] layer_y3 = new string[9];
        layer_y3[0] = "Cube";
        layer_y3[1] = "Cube.001";
        layer_y3[2] = "Cube.002";
        layer_y3[3] = "Cube.015";
        layer_y3[4] = "Cube.016";
        layer_y3[5] = "Cube.017";
        layer_y3[6] = "Cube.018";
        layer_y3[7] = "Cube.019";
        layer_y3[8] = "Cube.020";

        string[] layer_z1 = new string[9];
        layer_z1[0] = "Cube";
        layer_z1[1] = "Cube.001";
        layer_z1[2] = "Cube.002";
        layer_z1[3] = "Cube.003";
        layer_z1[4] = "Cube.004";
        layer_z1[5] = "Cube.005";
        layer_z1[6] = "Cube.006";
        layer_z1[7] = "Cube.007";
        layer_z1[8] = "Cube.008";

        string[] layer_z2 = new string[9];

        layer_z2[0] = "Cube.009";
        layer_z2[1] = "Cube.010";
        layer_z2[2] = "Cube.011";
        layer_z2[3] = "Cube.012";
        layer_z2[4] = "Cube.013";
        layer_z2[5] = "Cube.014";
        layer_z2[6] = "Cube.015";
        layer_z2[7] = "Cube.016";
        layer_z2[8] = "Cube.017";

        string[] layer_z3 = new string[9];
        layer_z3[0] = "Cube.018";
        layer_z3[1] = "Cube.019";
        layer_z3[2] = "Cube.020";
        layer_z3[3] = "Cube.021";
        layer_z3[4] = "Cube.022";
        layer_z3[5] = "Cube.023";
        layer_z3[6] = "Cube.024";
        layer_z3[7] = "Cube.025";
        layer_z3[8] = "Cube.026";

       
        setlayer(layer, layer_z3);

    }
    public void setlayer(string layer,string[] layerelemnt) {
        for (int i = 0; i <= 8; i++) {
             group1 = this.gameObject.AddComponent<group>() ;
            group1.layer_change(layer,layerelemnt[i] );
   
        }
    }


	// Update is called once per frame
	void Update () {
       


	}
}
