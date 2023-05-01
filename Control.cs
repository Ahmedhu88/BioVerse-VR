using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    float _time=0,ptime=0;
    Animator anm;
     [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private string controllerName;
    [SerializeField] private string actionNameGrip;
    private InputActionMap _actionMap;
    private InputAction _inputActionGrip;
    public bool press=false,isEnter=false,dis=false,denter=false,press1=false,about=false;
    // Start is called before the first frame update
    void Awake()
    {
        _actionMap=actionAsset.FindActionMap(controllerName);
        _inputActionGrip=_actionMap.FindAction(actionNameGrip);
    }
     private void Start() {
        anm=GameObject.Find("rotdoor").gameObject.GetComponent<Animator>();    
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
         {
            if(Time.realtimeSinceStartup> ptime+1)
            {
                press=!press;
                ptime=Time.realtimeSinceStartup;
            }
            press1=true;
            //_time=Time.realtimeSinceStartup;
         }else
         press1=false;
         //GameObject.Find("Canvas2").gameObject.transform.position= this.gameObject.transform.position;
        if(isEnter && press && !dis && Time.realtimeSinceStartup>_time+1)
            {
                displayOn();
                _time=Time.realtimeSinceStartup;
            }
        if(dis && !press ) 
        {
            GameObject.Find("Canvas2").gameObject.transform.position=new Vector3(-9999,-9999,-9999) ;
            dis=false;
        }
        if(denter&& press1 && Time.realtimeSinceStartup>_time+1)
        {
            Debug.Log("ooooooooooooooooooooooooooooooooooo");
            anm.Play("open",0,0.0f);
            _time=Time.realtimeSinceStartup;
           // SceneManager.LoadScene("SampleScene");
          //  GameObject.Find("dcyl").gameObject.transform.rotation=Quaternion.Lerp(Quaternion.Euler(Vector3.zero),Quaternion.Euler(new Vector3(400,0,0)),Time.deltaTime);
        }

        
    }

    public void Enter()
    {
        
        isEnter=true;
        //Debug.Log(dis);
        GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text="Name: "+this.gameObject.GetComponent<variables>().Label;
        GameObject.Find("Text2").GetComponent<UnityEngine.UI.Text>().text="Chrom: "+this.gameObject.GetComponent<variables>().Chromosome;
    }
    public void displayOn()
        {
            if(GameObject.Find("Canvas2").transform.position.x==-9999)
            {
                dis=true;
            
           // GameObject.Find("Canvas2").gameObject.SetActive(true);
            GameObject.Find("Canvas2").gameObject.transform.position=new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y+35,this.gameObject.transform.position.z) ;
            GameObject.Find("Canvas2").gameObject.transform.rotation=Quaternion.LookRotation(transform.position- GameObject.Find("XROrigin").gameObject.transform.position);
            if(this.GetComponent<variables>().url!=null)
            GameObject.Find("BrowserVR").GetComponent<ZenFulcrum.EmbeddedBrowser.Browser>().LoadURL(this.GetComponent<variables>().url,true);
            else
            GameObject.Find("BrowserVR").GetComponent<ZenFulcrum.EmbeddedBrowser.Browser>().LoadURL("www.google.com",true);
            }
    }
    
    public void Exit()
    {   //GameObject.Find("Canvas2").gameObject.SetActive(false);
        isEnter=false;
        //GameObject.Find("Canvas2").gameObject.transform.position=new Vector3(-9999,-9999,-9999) ;
    
        GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text="";
        GameObject.Find("Text2").GetComponent<UnityEngine.UI.Text>().text="";
    }
public    void doorenter()
    {
        denter=true;
    }
      public  void doorexit()
    {
        denter=false;
    }
    public void aboutin()
    {about=true;}
    public void aboutout()
    {about=false;}
}
