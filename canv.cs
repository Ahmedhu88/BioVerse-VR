using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class canv : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private string controllerName;
    [SerializeField] private string actionNameGrip;
    private InputActionMap _actionMap;
    private InputAction _inputActionGrip;

    // Start is called before the first frame update
    void Awake()
    {
        _actionMap=actionAsset.FindActionMap(controllerName);
        _inputActionGrip=_actionMap.FindAction(actionNameGrip);
    }
     void OnEnable()
    {
      _inputActionGrip.Enable();
    }
     void OnDisable()
    {
        _inputActionGrip.Disable();
    }


    // Update is called once per frame
    void Update()
    {
        var UpValue=_inputActionGrip.ReadValue<float>(); 
        
        //GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text=DownValue.ToString();
         if(UpValue>0)
        GameObject.Find("Canvas2").gameObject.transform.position= this.gameObject.transform.position;
    }
}
