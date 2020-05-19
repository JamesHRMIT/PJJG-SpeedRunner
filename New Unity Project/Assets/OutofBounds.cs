using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutofBounds : MonoBehaviour
{
    public float outOfMap = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if{ gameObject.transform.position.y <= outOfMap}
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetSceneByName("SampleScene"));
            
        }
    }
}
