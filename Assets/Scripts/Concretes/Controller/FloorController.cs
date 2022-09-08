using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerGame.Controller
{
    public class FloorController : MonoBehaviour
    {
        [Range(0.5f, 2f)]
        [SerializeField] float MoveSpeed;
        Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;            
        }

        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * MoveSpeed * Time.deltaTime;
        }
    }

}
