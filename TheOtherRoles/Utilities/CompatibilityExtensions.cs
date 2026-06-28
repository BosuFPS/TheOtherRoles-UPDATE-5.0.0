using System.IO;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace TheOtherRoles.Utilities;

public static class CompatibilityExtensions
{
    public static void Destroy<T>(this T obj) where T : Object
    {
        if (obj != null) Object.Destroy(obj);
    }

    public static byte[] ReadFully(this Stream stream)
    {
        using var memory = new MemoryStream();
        stream.CopyTo(memory);
        return memory.ToArray();
    }

    public static T LoadAsset<T>(this AssetBundle bundle, string name) where T : Object
    {
        return bundle.LoadAsset(name, Il2CppType.Of<T>()).Cast<T>();
    }

    public static T DontUnload<T>(this T obj) where T : Object
    {
        if (obj != null) obj.hideFlags |= HideFlags.DontUnloadUnusedAsset;
        return obj;
    }
}
