using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreak : MonoBehaviour
{

    private SpriteRenderer sr;

    public Sprite explodedBlock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sr = GetComponent<SpriteRenderer>(); // comment
    }

    // Called when something hits the BrickBlock
    void OnCollisionEnter2D(Collision2D other)
    {
    // Check if the collision hit the bottom of the block
    if (other.gameObject.tag == "Player" && other.GetContact(0).point.y < transform.position.y)
    {
        // Change the Block sprite
        sr.sprite = explodedBlock;
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        // Wait a fraction of a second and then destroy the BrickBlock
        Object.Destroy(gameObject, .2f);
    }
}
}
