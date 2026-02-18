using UnityEngine;
/// <summary>
/// 测试类
/// </summary>
class Test : MonoBehaviour
{
    public Material material = null;
    public Mesh mesh = null;
    private TreeModel treeModel = null;

    private Tree[] trees = new Tree[3];

    private void Start()
    {
        treeModel = new TreeModel(mesh, material); //内部状态仅创建一个实例对象

        trees[0] = new Tree(treeModel, new Vector3(0, 0, 0));
        trees[1] = new Tree(treeModel, new Vector3(5, 0, 5));
        trees[2] = new Tree(treeModel, new Vector3(-5, 0, -5));
    }

    private void Update()
    {
        foreach (Tree tree in trees)
        {
            tree.Draw();
        }
    }
}