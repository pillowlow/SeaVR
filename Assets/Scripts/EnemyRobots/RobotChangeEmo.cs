using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class RobotChangeEmo : MonoBehaviour
{   

    public Texture[] myMaps;
    public Color[] mycolors;
    public float[] intensities;
    public int index = 0;
    public Material TargetMat;

    private int ChangeDetecter;
    // Start is called before the first frame update
    void Start()
    {   

        if(index > myMaps.Length-1){

            index = 0;
        }
        

        ChangeDetecter = index;
        TargetMat.SetTexture("_Emission",myMaps[ChangeDetecter]);
        float factor = 0;
        if(intensities.Length>=index){
            factor = intensities[index]*intensities[index];
        }
        
        Color temp  = new Color(mycolors[index].r*factor,mycolors[index].g*factor,mycolors[index].b*factor);

        TargetMat.SetColor("_EmiColor",temp);


    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(index+10*ChangeDetecter);
        if (ChangeDetecter != index){
            ChangeDetecter = index;
            TargetMat.SetTexture("_Emission",myMaps[ChangeDetecter]);
        }
        
    }
}
