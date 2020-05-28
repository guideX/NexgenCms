using System;
using System.Linq;
/// <summary>
/// Class Extensions
/// </summary>
public static class ClassExtensions {
    /// <summary>
    /// Do All Method Results Have Base Class
    /// </summary>
    /// <param name="cls"></param>
    /// <param name="baseClass"></param>
    /// <returns></returns>
    public static void DoAllMethodResultsHaveBaseClass(this Type cls, Type baseClass) {
        var methods = cls.GetMethods().Where(meth => !meth.Name.ToLower().Contains("dispose") && meth.DeclaringType == cls && !meth.IsConstructor && !meth.IsSpecialName && !meth.ReturnType.IsSubclassOf(baseClass)).ToList();
        foreach (var method in methods) throw new Exception("In the class: '" + cls.Name + "', method: + '" + method.Name + "', the result '" + method.ReturnType.Name + "' does not contain the base class of '" + baseClass.Name + "'.");
    }
}