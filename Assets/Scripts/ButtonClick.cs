using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ButtonClick : MonoBehaviour
{
    private Button button;
    private int index;

    void Awake()
    {
        button = this.GetComponent<Button>();
        if(this.transform.parent.name == "MainButtons") button.onClick.AddListener(ChangeFaceMaterialMain);
        else     button.onClick.AddListener(ChangeFaceMaterialOther);
        index = this.gameObject.transform.GetSiblingIndex();
    }
    void ChangeFaceMaterialMain()
    {
        ARFaceController.aRFaceController.ChangeFaceMaterialMain(index);
    }
    void ChangeFaceMaterialOther()
    {
        ARFaceController.aRFaceController.ChangeFaceMaterialOther(index);
    }
    
    
}
