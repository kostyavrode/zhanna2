using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
    {
    float MouseX { get; set; }
    float MouseY { get; set; }
    float Horizontal { get; set; }
    float Vertical { get; set; }
}
