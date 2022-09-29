using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] sprite;
    public int spriteAmount;

    Random rand;
    SpriteRenderer spriteRen;

    // Start is called before the first frame update
    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();

        int rand = Random.Range(0, spriteAmount);

        spriteRen.sprite = sprite[rand];
    }
}
