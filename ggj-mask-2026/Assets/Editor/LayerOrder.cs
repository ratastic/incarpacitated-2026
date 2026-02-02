//using UnityEngine;
//using UnityEditor;

//[CustomEditor(typeof(MyScript))]
//public class LayerOrder : Editor
//{
//    SerializedProperty m_Name;
//    SerializedProperty m_Order;

//    private SpriteRenderer rend;

//    void OnEnable()
//    {
//        // Fetch the properties from the MyScript script and set up the SerializedProperties.
//        m_Name = serializedObject.FindProperty("MyName");
//        m_Order = serializedObject.FindProperty("MyOrder");
//    }
//    void CheckRenderer()
//    {
//        //Check that the GameObject you select in the hierarchy has a SpriteRenderer component
//        if (Selection.activeGameObject.GetComponent<SpriteRenderer>())
//        {
//            //Fetch the SpriteRenderer from the selected GameObject
//            rend = Selection.activeGameObject.GetComponent<SpriteRenderer>();
//            //Change the sorting layer to the name you specify in the TextField
//            //Changes to Default if the name you enter doesn't exist
//            rend.sortingLayerName = m_Name.stringValue;
//            //Change the order (or priority) of the layer
//            rend.sortingOrder = m_Order.intValue;
//        }
//    }
//        // Start is called once before the first execution of Update after the MonoBehaviour is created
//        void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyScript))]
public class LayerOrder : Editor
{
    SerializedProperty m_Name;
    SerializedProperty m_Order;

    private SpriteRenderer rend;

    void OnEnable()
    {
        m_Name = serializedObject.FindProperty("MyName");
        m_Order = serializedObject.FindProperty("MyOrder");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(m_Name);
        EditorGUILayout.PropertyField(m_Order);

        serializedObject.ApplyModifiedProperties();

        if (GUILayout.Button("Apply To Selected"))
            CheckRenderer();
    }

    void CheckRenderer()
    {
        if (Selection.activeGameObject != null &&
            Selection.activeGameObject.GetComponent<SpriteRenderer>())
        {
            rend = Selection.activeGameObject.GetComponent<SpriteRenderer>();
            rend.sortingLayerName = m_Name.stringValue;
            rend.sortingOrder = m_Order.intValue;
        }
    }
}
#endif
