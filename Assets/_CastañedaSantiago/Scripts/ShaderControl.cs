using UnityEngine;

public class ShaderControl : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private string _propertyName = "_MainColor";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // renderer.material.setColor()               solo funciona con propiedad _MainColor
            //_renderer.material.SetColor(_propertyName, _color); //Flexible para cualquier propiedad de color
            _renderer.material.SetColor(_propertyName, Color.HSVToRGB(Random.value, 1, 1));
        }
    }
}
