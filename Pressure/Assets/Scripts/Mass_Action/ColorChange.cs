using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] Material Color_fp;
    [SerializeField] Material Color_sp;

    public bool Flag_fp;
    private Renderer Mass_renderer;
    // Start is called before the first frame update
    void Start()
    {
        Flag_fp = true;
        Mass_renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Flag_fp)
            {
                GetComponent<Renderer>().material = Color_fp;

                Flag_fp = false;
            }
            else
            {
                GetComponent<Renderer>().material = Color_sp;

                Flag_fp = true;
            }
        }
    }
}
