using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class ARFaceController : MonoBehaviour
{

   public static ARFaceController aRFaceController;
    [SerializeField] private ARFaceManager aRFaceManager;
    public List<Material> mainMaterials = new List<Material>();
    public List<Material> otherMaterials = new List<Material>();


    void Awake()
    {
       aRFaceController = this;
        
        
    }
    public void ChangeFaceMaterialMain(int index)
    {
       //passing a single material - foundation type
        foreach(var face in aRFaceManager.trackables)
        {
            Material[] mat = {mainMaterials[index]};
            face.GetComponent<MeshRenderer>().materials = mat;
        }


    }
    public void ChangeFaceMaterialOther(int index)
    {
       
       //passingmultiple materials to get combined color
        foreach(var face in aRFaceManager.trackables)
        {
            Material[] mat = {face.GetComponent<Material>(), otherMaterials[index] };
            face.GetComponent<MeshRenderer>().materials = mat;
        }



    }

}
