using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Biological Network");
    }
    // Start is called before the first frame update

}
