using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Get_key();
    }

    void Get_key()
    {
        if (Input.GetButtonDown("1P_Decision"))
        {
            Debug.Log("1P_����");
        }
        else if (Input.GetButtonDown("1P_Back"))
        {
            Debug.Log("1P_�߂�");
        }

        if(Input.GetButtonDown("1P_Left"))
        {
            Debug.Log("1P_��");
        }
        else if(Input.GetButtonDown("1P_Right"))
        {
            Debug.Log("1P_�E");
        }

        if(Input.GetAxis("1P_Select_X") != 0)
        {
            Debug.Log("1P_���E");
        }
        else if(Input.GetAxis("1P_Select_Y") != 0)
        {
            Debug.Log("1P_�㉺");
        }

        if(Input.GetButtonDown("2P_Decision"))
        {
            Debug.Log("2P_����");
        }
        else if(Input.GetButtonDown("2P_Back"))
        {
            Debug.Log("2P_�߂�");
        }

        if(Input.GetButtonDown("2P_Left"))
        {
            Debug.Log("2P_��");
        }
        else if(Input.GetButtonDown("2P_Right"))
        {
            Debug.Log("2P_�E");
        }

        if(Input.GetAxis("2P_Select_X") != 0)
        {
            Debug.Log("2P_���E");
        }
        else if(Input.GetAxis("2P_Select_Y") != 0)
        {
            Debug.Log("2P_�㉺");
        }
    }
}
