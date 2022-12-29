using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {
    
    public Vector2 speedMinMax;
    float speed;
    float visibleHeightThreshold;

    void Start() {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultPercent());
        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    void Update() {  
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
        if (transform.position.y < visibleHeightThreshold) {
            Destroy(gameObject);
        }
    }
}
