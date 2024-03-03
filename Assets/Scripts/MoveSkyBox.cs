using UnityEngine;

public class MoveSkyBox : MonoBehaviour
{
    [SerializeField] private MeshRenderer _mesh;
    private float moveSpeedSky = 0.0625f;
    private Vector2 _meshOffset;
    void Start()
    {
        _meshOffset = _mesh.sharedMaterial.mainTextureOffset;
    }

    private void OnDisable() 
    {
        _mesh.sharedMaterial.mainTextureOffset = _meshOffset;
    }

    void Update()
    {
        var x = Mathf.Repeat(Time.time * moveSpeedSky, 1);
        var offset = new Vector2(x, _meshOffset.y);

        _mesh.sharedMaterial.mainTextureOffset = offset;
    }
}
