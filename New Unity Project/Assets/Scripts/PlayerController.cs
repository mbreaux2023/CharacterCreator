using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public List<UnityEngine.UI.Button> WeaponButtons;

    public SpriteRenderer WeaponRenderer;
    public SpriteRenderer ArmorRenderer;
    // Start is called before the first frame update
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }

    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }

    
    public void SetRandomWeapon()
    {
        int randomNumber = Random.Range(0, 6);
        this.WeaponButtons[randomNumber].onClick.Invoke();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
