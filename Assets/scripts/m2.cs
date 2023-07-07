using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 1;
            this.transform.position = position;
        }//move object in -x diriction

        if (Input.GetKeyDown(KeyCode.RightArrow))

        {
            Vector3 position = this.transform.position;
            position.x = position.x + 1;
            this.transform.position = position;

        }//move object in +x diriction
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            Vector3 position = this.transform.position;
            position.y = position.y + 1;
            this.transform.position = position;
        }//move object in y diriction
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            Vector3 position = this.transform.position;
            position.y = position.y - 1;
            this.transform.position = position;
        }//move object in -y diriction
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + 1;
            this.transform.position = position;
        }//move object in z diriction
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - 1;
            this.transform.position = position;
        }//move object in -z diriction
        
    }
}
