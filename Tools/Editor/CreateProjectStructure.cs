using UnityEditor;
using UnityEngine;

using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;

using static System.IO.Directory;
using static System.IO.Path;

namespace BakewareSoftwareTools
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            var dataPathStrings = Application.dataPath.Split("/");
            var projectName = dataPathStrings[^2];
            
            projectName = projectName.Substring(0, 2) == "U." 
                ? projectName.Remove(0, 2) 
                : projectName;

            Debug.Log(projectName);
            
            Dir("_"+projectName, "Assets", "Content", "Scripts", "Settings",
                "Assets/Materials", "Assets/Models", "Assets/Music", "Assets/SFX", "Assets/Textures", 
                "Content/Prefabs", "Content/Scenes", "Content/Ui",
                "Scripts/Design Patterns");
            Refresh();
        }

        private static void Dir(string root, params string[] directories)
        {
            var fullPath = Combine(dataPath, root);
            
            foreach (var newDir in directories) 
                CreateDirectory(Combine(fullPath, newDir));
        }
    }
}
