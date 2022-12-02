using UnityEngine;

public class WinchDrumCalc : MonoBehaviour
{

    [SerializeField] float drumSpindleDia = 20;
    //[SerializeField] float drumFlangeDia = 180;
    [SerializeField] float ropeDia = 2.38f;
    [SerializeField] float flangeWidth = 80;

    float anyLayer;

    //float firstLayer = drumSpindleDia + ropeDia;
    //float standardLayer = (drumSpindleDia + drumFlangeDia) / 2;
    [SerializeField] int wrapCount = 20;

    private void Update()
    {
        for (int i = 0; i <= wrapCount; i++)
        {
            for (int j = 0; j <= wrapCount; j++)
            {
                anyLayer = Mathf.PI * (flangeWidth / ropeDia - 1) * (drumSpindleDia + ((2 * j - 1) * ropeDia)) / 1000;
            Debug.Log($"Length layer {wrapCount}: {anyLayer}");
            }

            anyLayer += anyLayer;
        }
        Debug.Log($"Total length: {anyLayer}");
    }
}
