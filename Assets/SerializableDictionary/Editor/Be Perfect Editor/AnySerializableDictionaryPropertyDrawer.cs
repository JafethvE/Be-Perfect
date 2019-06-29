using BePerfect;
using UnityEditor;

namespace BePerfectEditor
{ 
    [CustomPropertyDrawer(typeof(ColourMaterialDictionary))]
    [CustomPropertyDrawer(typeof(ColourCrystalPartDictionary))]
    public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer
    {
    }
}