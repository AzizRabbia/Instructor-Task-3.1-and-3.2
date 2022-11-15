using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffsetController : MonoBehaviour
{
    private MeshRenderer rend;
    public float speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>(); 
    }
    // Update is called once per frame
    void Update()
    {
        //Parallex effect of moving the offset of the texture of the material
        rend.material.mainTextureOffset += new Vector2(speed, 0);
    }
}
