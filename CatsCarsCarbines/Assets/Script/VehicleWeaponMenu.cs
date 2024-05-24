using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VehicleWeaponMenu : MonoBehaviour
{
    // Vehicle/Weapon
    [SerializeField]
    Button vehicleWeaponButton;

    [SerializeField]
    TMP_Text vehicleWeaponButtonText;

    [SerializeField]
    TMP_Text vehicleWeaponName;

    [SerializeField]
    GameObject vehicle;

    [SerializeField]
    GameObject weapon;

    // Cost
    [SerializeField]
    Button costButton;

    [SerializeField]
    TMP_Text costButtonText;

    // Arrows
    [SerializeField]
    Button rightArrowButton;

    [SerializeField]
    Button leftArrowButton;


    // Start is called before the first frame update
    void Start()
    {
        vehicleWeaponName.text = "Cardboard Box";

        vehicleWeaponButtonText.text = "Vehicles";

        costButtonText.text = "1500 Coins";

        vehicle.GetComponent<Renderer>().enabled = true;
        weapon.GetComponent<Renderer>().enabled = false;

    }

    

    // Change from Vehicles menu to Weapons menu 
    public void ChangeMenu()
    {
        // if clicked to change to weapons
        if (vehicleWeaponButtonText.text == "Vehicles")
        {
            vehicleWeaponButton.GetComponent<Image>().color = new Color32(56, 150, 81, 255);
            vehicleWeaponButtonText.text = "Weapons";

            vehicleWeaponName.text = "Laser Pointer";

            vehicle.GetComponent<Renderer>().enabled = false;
            weapon.GetComponent<Renderer>().enabled = true;

        }
        // if clicked to change to vehicles
        else if (vehicleWeaponButtonText.text == "Weapons")
        {
            vehicleWeaponButton.GetComponent<Image>().color = new Color32(122, 24, 239, 255);
            vehicleWeaponButtonText.text = "Vehicles";

            vehicleWeaponName.text = "Cardboard Box";

            vehicle.GetComponent<Renderer>().enabled = true;
            weapon.GetComponent<Renderer>().enabled = false;
        }
    }



    // Shows you purchased vehicle or weapon
    public void CostButton()
    {
        costButtonText.text = "Purchased!";
        costButton.GetComponent<Image>().color = new Color32(237, 159, 84, 255);
        costButtonText.color = Color.white;
    }


}
