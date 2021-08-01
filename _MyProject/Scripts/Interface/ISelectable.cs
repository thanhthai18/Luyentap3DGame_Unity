using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public interface ISelectable
    {
        SelectableObj Check(Ray ray);
        Transform GetTransform();
    }
}
