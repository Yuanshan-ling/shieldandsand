#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public static class OpenDefaultSceneOnProjectLaunch
{
    private const string DefaultScenePath =
        "Assets/Scenes/shieldandsand.unity";

    static OpenDefaultSceneOnProjectLaunch()
    {
        EditorApplication.delayCall += OpenDefaultSceneWhenNeeded;
    }

    private static void OpenDefaultSceneWhenNeeded()
    {
        if (EditorApplication.isPlayingOrWillChangePlaymode)
        {
            return;
        }

        // 主场景不存在时，不执行任何操作。
        if (AssetDatabase.LoadAssetAtPath<SceneAsset>(DefaultScenePath) == null)
        {
            return;
        }

        Scene activeScene = SceneManager.GetActiveScene();

        // 仅在项目刚打开、当前是 Untitled 空场景时自动载入。
        if (string.IsNullOrEmpty(activeScene.path))
        {
            EditorSceneManager.OpenScene(
                DefaultScenePath,
                OpenSceneMode.Single
            );
        }
    }
}
#endif
