using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleGB : MonoBehaviour
{   
    public Sprite[] backgroundSprites;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, backgroundSprites.Length);
        Sprite selectedBackground = backgroundSprites[randomIndex];

        // Thiết lập background cho Sprite Renderer (điều này giả sử bạn đã có một Sprite Renderer)
        GetComponent<SpriteRenderer>().sprite = selectedBackground;
        // SpriteRenderer sr = GetComponent<SpriteRenderer>();
        // Vector3 tempScale = transform.localScale;

        // float height = sr.bounds.size.y;
        // float width = sr.bounds.size.x;

        // float worldHight = Camera.main.orthographicSize * 2f;
        // float worldWidth = worldHight*Screen.width/Screen.height;
       
        // tempScale.y = worldHight / height;
        // tempScale.x = worldWidth/width;
        // transform.localScale = tempScale;
    
    }

}
