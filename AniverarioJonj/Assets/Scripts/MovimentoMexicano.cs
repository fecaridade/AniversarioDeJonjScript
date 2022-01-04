using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.AssetImporters;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MovimentoMexicano : MonoBehaviour
{
    
    private float speed = 40f;
    [SerializeField] private RectTransform _transform;
    private bool direita;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direita)
        {
            _transform.anchoredPosition = new Vector2(transform.position.x+ speed*Time.deltaTime,_transform.position.y);
            _transform.GetComponent<SpriteRenderer>().flipX = true;
            
        }
        else
        {
            _transform.anchoredPosition = new Vector2(transform.position.x- speed*Time.deltaTime,_transform.position.y);
            _transform.GetComponent<SpriteRenderer>().flipX = false;
            
            
        }
        
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "Esquerda")
        {
            direita = true;
        }
        else if (other.gameObject.name == "Direita")
        {
            direita = false;
        }
    }
}


