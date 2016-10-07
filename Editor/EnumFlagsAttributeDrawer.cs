
// ---
// This is EnumFlagsAttributeDrawer.cs
// This file needs to be placed in an "Editor" directory.
// ---
using UnityEngine;
using UnityEditor;


/// <summary>
/// This allows us to use an Enum as a masking field (just like the LayerMask in Unity).
/// </summary>

/// <example>
///
/// // First define the Enumeration type and follow .NET-friendly practice of specifying it with System.FlagsAttribute.
/// [System.Flags]
/// enum MyFlagType
/// {
///     Zero = 0,
///     One = (1 << 0),
///     Two = (1 << 1),
///     Three = (1 << 2)
/// }
///
/// // Now define the actual field, and tag on the EnumFlagsFieldAttribute.
/// [SerializeField, EnumFlagsField] MyFlagType     _fieldName;
///
/// </example>

[CustomPropertyDrawer(typeof(EnumFlagsFieldAttribute))]
class EnumFlagsAttributeDrawer : PropertyDrawer
{
    private System.Type _objectType;

    public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
    {
        _property.intValue = EditorGUI.MaskField(_position, _label, _property.intValue, _property.enumNames);
    }
}
