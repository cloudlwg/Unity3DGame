using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class ExitTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {

            Application.Quit();
            //Debug.Log("Click it");

        });
        
    }

   
    // Update is called once per frame
    void Update()
    {

    }


}
