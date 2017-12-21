using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    
    int count = 1;
    bool triggle=false;
    bool set = true;
    public o1 o1;
    public int[] steplist;
    void Start()
    {
        o1 = this.gameObject.AddComponent<o1>();
        triggle = false;
        
    }

    // Update is called once per frame
    void Update()
    {



        //// whilie  (count < 440)  if use update do not need while,if used while be finished at one frame
        //if (triggle == true)
        //{
        ////    if (this.transform.rotation!= new Quaternion(-0.5f, 0.5f, -0.5f, 0.5f)) not good as dealtime can be some deviation
        ////     if(count<=60)
        //    {
        //        Debug.Log(this.transform.rotation);
        //        transform.Rotate(new Vector3(0, 90, 0) * speed*Time.deltaTime); if 30fps this equre to vector (0,3,0) 
        ////transform.Rotate(new Vector3(0, 90, 0) );   


        //    }
        //    else
        //    {
        //        triggle = false;

        //    }
        //}

        if (triggle == true)
        {
            if (count <= 89)
            {
                switch (this.gameObject.tag)
                {
                    case "x1":
 
                 transform.Rotate(new Vector3(1, 0, 0));
                        break;

                    case "x2":

                        transform.Rotate(new Vector3(1, 0, 0));
                        break;
                    case "z1":

                        transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case "z2":

                        transform.Rotate(new Vector3(0,- 1, 0));
                        break;
                    case "y1":

                        transform.Rotate(new Vector3(0, 0,-1));
                        break;
                    case "y2":

                        transform.Rotate(new Vector3(0, 0, -1));
                        break;



                }
                count++;


            
                



              


            }

            
            else
            {
                triggle = false;
                set = true;
                o1.clearlist();
                count = 0;
                Debug.Log(arrow_manager.looptime);
                arrow_manager.looptime++;
            }
        }
    }


    
    private void OnCollisionEnter(Collision collision)
    {

        if (this.gameObject.CompareTag("x1"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.022_x1", o1.layerelemnt);



                }
                triggle = true;
                Debug.Log("x1");
            }
        }else if (this.gameObject.CompareTag("x2"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.005_x2", o1.layerelemnt);

                }
                triggle = true;
                Debug.Log("x2");
            }
        }
        if (this.gameObject.CompareTag("y1"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.016_y1", o1.layerelemnt);

                }
                triggle = true;

                Debug.Log("y1");
            }
        }
        if (this.gameObject.CompareTag("y2"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.011_y2", o1.layerelemnt);

                }
                triggle = true;
                Debug.Log("y2");
            }
        }
        if (this.gameObject.CompareTag("z1"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.014_z1", o1.layerelemnt);

                }
                triggle = true;
                Debug.Log("z1");
            }
        }
        if (this.gameObject.CompareTag("z2"))
        {
            if (steplist[arrow_manager.looptime] == 1)
            {
                if (set)
                {
                    set = false;
                    o1.setlayer("Cube.013_z2", o1.layerelemnt);

                }
                triggle = true;
                Debug.Log("z2");
            }
        }


    }

}

