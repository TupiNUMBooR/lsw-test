using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class Builder
    {
        public static void BuildDefault()
        {
            Build("Windows64", BuildTarget.StandaloneWindows64, true, true);
            Build("Linux64", BuildTarget.StandaloneLinux64, true, true);
            Build("Android", BuildTarget.Android, false, true);
            Build("WebGL", BuildTarget.WebGL, false, true);
        }

        public static void BuildPC()
        {
            Build("Windows64", BuildTarget.StandaloneWindows64, true, true);
            Build("Linux64", BuildTarget.StandaloneLinux64, true, true);
        }

        static void Build(string platform, BuildTarget bt, bool notDev, bool dev)
        {
            var l = (from scene in EditorBuildSettings.scenes where scene.enabled select scene.path).ToArray();
            if (notDev) BuildPipeline.BuildPlayer(l, Path("", platform), bt, BuildOptions.None);
            if (dev) BuildPipeline.BuildPlayer(l, Path("Dev", platform), bt, BuildOptions.Development);
        }

        static string Path(string type, string platform)
        {
            return $"Builds/Basic{type}/{platform}/{Application.productName}/{Application.productName}";
        }
    }
}