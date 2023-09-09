using UnityEngine;
using Random = UnityEngine.Random;

public class ChaosBallColorChange : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private Material[] allPossibleMaterials;
    
    [SerializeField] private float timeChange = 35;

    private float t;

    private void Awake()
    {
        ChangeColor();
    }

    private void Update()
    {
        t += Time.deltaTime;

        if (t >= timeChange)
        {
            t = 0;
            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        meshRenderer.sharedMaterial = GetRandomMaterial();
    }

    private Material GetRandomMaterial()
    {
        int randIndex = Random.Range(0, allPossibleMaterials.Length);
        return allPossibleMaterials[randIndex];
    }
}
