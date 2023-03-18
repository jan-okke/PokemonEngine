using System.Reflection;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class DeepCloningExtension
    {
        public static T DeepClone<T>(this T obj) where T : new()
        {
            if (obj == null)
            {
                return default(T);
            }

            T newObj = new T();

            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                var fieldValue = field.GetValue(obj);
                if (fieldValue != null && !fieldValue.GetType().IsPrimitive)
                {
                    field.SetValue(newObj, DeepClone(fieldValue));
                }
                else
                {
                    field.SetValue(newObj, fieldValue);
                }
            }

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var property in properties)
            {
                if (property.CanWrite && property.CanRead)
                {
                    var propertyValue = property.GetValue(obj);
                    if (propertyValue != null && !propertyValue.GetType().IsPrimitive)
                    {
                        property.SetValue(newObj, DeepClone(propertyValue));
                    }
                    else
                    {
                        property.SetValue(newObj, propertyValue);
                    }
                }
            }

            return newObj;
        }

    }
}