using UnityEngine;

/// <summary>
/// 享元模式：内部状态
/// </summary>
public class TreeModel
{
    public Mesh Mesh;
    public Material material;

    public TreeModel(Mesh mesh, Material mat)
    {
        Mesh = mesh;
        material = mat;
    }
}

/// <summary>
/// 享元模式：外部状态
/// </summary>
public class Tree
{
    private TreeModel _model; //引用共享内部状态

    public Vector3 Position;
    public Tree(TreeModel model, Vector3 pos)
    {
        _model = model;
        this.Position = pos;
    }

    public void Draw()
    {
        Graphics.DrawMesh(_model.Mesh, Position, Quaternion.identity, _model.material, 0);
    }
}