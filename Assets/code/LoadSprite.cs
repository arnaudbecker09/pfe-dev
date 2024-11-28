using UnityEngine;
using UnityEngine.UI;

public class LoadSprite : MonoBehaviour
{
    public Image imageComponent;
    public Sprite newSprite;

    void Start()
    {
        imageComponent.sprite = newSprite;
    }
}
