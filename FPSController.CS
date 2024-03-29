using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] float sens =100f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * sens;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * sens;
        
        characterController.Move(new Vector3(horizontal, 0f, vertical));
    }
}
