﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Vector2 direction;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            TakeInput();
            Move();
        }

        private void TakeInput()
        {
            direction = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
            {
                direction += Vector2.up;
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction += Vector2.left;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direction += Vector2.down;
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction += Vector2.right;
            }
        }

        private void Move()
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}