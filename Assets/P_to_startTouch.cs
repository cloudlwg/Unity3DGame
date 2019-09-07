using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class P_to_startTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("StartGame");
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
