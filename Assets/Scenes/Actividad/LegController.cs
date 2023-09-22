using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;
using TMPro;

public class LegController : MonoBehaviour
{
    public string weight = "Weight";
    public Rig legRig;
    public Slider slider;
    public TextMeshProUGUI sliderText;


    private void Start()
    {

        slider.onValueChanged.AddListener(ChangeRightWeightValue);

    }
    private void Update()
    {

        sliderText.text = slider.value.ToString();

    }

    private void ChangeRightWeightValue(float value)
    {

        legRig.weight = value;

    }
}
