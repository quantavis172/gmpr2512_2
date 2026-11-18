using UnityEngine;
using UnityEngine.UIElements;

public class UIRootSizer : MonoBehaviour
{
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        root.StretchToParentSize();
    }

}
