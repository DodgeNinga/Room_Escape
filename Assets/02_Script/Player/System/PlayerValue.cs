using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValue : MonoBehaviour
{

    [field:SerializeField] public float moveSpeed { get; private set; }
    [field:SerializeField] public float jumpPower { get; private set; }
    [field:SerializeField] public float lookSensitivity { get; private set; }
    [field:SerializeField] public float maxRotate { get; private set; }
    [field:SerializeField] public float maxInteractionRange { get; private set; }

}
