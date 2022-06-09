using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider powerSlider;
    public Slider criticalSlider;
    public Slider speedSlider;
    public Slider armorSlider;


    int power_Value;
    int critical_Value;
    int speed_Value;
    int armor_Value;


    void Start()
    {
        power_Value = 1;
        critical_Value = 1;
        speed_Value = 1;
        armor_Value = 1;

    }


    public void PowerUp()
    {
        if (power_Value + 1<=powerSlider.maxValue)
        {
            power_Value++;
            
        }
        else
        {
            power_Value = (int)powerSlider.maxValue;
        }

        UpdatePowerSliderValue(powerSlider);
    }

    public void PowerDown()
    {
        if (power_Value - 1 >= powerSlider.minValue+1)
        {
            power_Value--;

        }
        else
        {
            power_Value = (int)powerSlider.minValue+1;
        }
        UpdatePowerSliderValue(powerSlider);
    }

    public void criticalUp()
    {
        if (critical_Value + 1 <= criticalSlider.maxValue)
        {
            critical_Value++;

        }
        else
        {
            critical_Value = (int)criticalSlider.maxValue;
        }

        UpdateCriticalSliderValue(criticalSlider);
    }

    public void criticalDown()
    {
        if (critical_Value - 1 >= criticalSlider.minValue + 1)
        {
            critical_Value--;

        }
        else
        {
            critical_Value = (int)criticalSlider.minValue + 1;
        }
        UpdateCriticalSliderValue(criticalSlider);
    }

    public void SpeedUp()
    {
        if (speed_Value + 1 <= speedSlider.maxValue)
        {
            speed_Value++;

        }
        else
        {
            speed_Value = (int)speedSlider.maxValue;
        }

        UpdateSpeedSliderValue(speedSlider);
    }

    public void SpeedDown()
    {
        if (speed_Value - 1 >= speedSlider.minValue + 1)
        {
            speed_Value--;

        }
        else
        {
            speed_Value = (int)speedSlider.minValue + 1;
        }
        UpdateSpeedSliderValue(speedSlider);
    }

    public void ArmorUp()
    {
        if (armor_Value + 1 <= armorSlider.maxValue)
        {
            armor_Value++;

        }
        else
        {
            armor_Value = (int)armorSlider.maxValue;
        }

        UpdateArmorSliderValue(armorSlider);
    }

    public void ArmorDown()
    {
        if (armor_Value - 1 >= armorSlider.minValue + 1)
        {
            armor_Value--;

        }
        else
        {
            armor_Value = (int)armorSlider.minValue + 1;
        }
        UpdateArmorSliderValue(armorSlider);
    }

    private void UpdatePowerSliderValue(Slider slider)
    {
        slider.value = (float)power_Value;
    }
    private void UpdateCriticalSliderValue(Slider slider)
    {
        slider.value = (float)critical_Value;
    }
    private void UpdateSpeedSliderValue(Slider slider)
    {
        slider.value = (float)speed_Value;
    }
    private void UpdateArmorSliderValue(Slider slider)
    {
        slider.value = (float)armor_Value;
    }
}
