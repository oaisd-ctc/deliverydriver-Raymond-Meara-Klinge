using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivering : MonoBehaviour
{
    [SerializeField]
    Color32 packColor = new Color32(115, 255, 115, 255);

    [SerializeField]
    Color32 unpackColor = new Color32(255, 255, 255, 255);

    [SerializeField]
    float deloy = 0.5f;

    bool packhas;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("HEY, I felt that! >= (");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Delivered" && packhas == true)
        {
            Debug.Log("Package delivered sir/maam.");
            packhas = false;
            spriteRenderer.color = unpackColor;
        }
        else if (other.tag == "Packing" && !packhas)
        {
            Debug.Log("Obtained the package.");
            packhas = true;
            spriteRenderer.color = packColor;
            Destroy(other.gameObject, deloy);
        }
    }
}
