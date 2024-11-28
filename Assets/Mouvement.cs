using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print hello world
        Debug.Log("Hello World");
        //move the object on the arrows keys
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
        


    }
}
