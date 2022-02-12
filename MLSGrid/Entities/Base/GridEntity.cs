using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MLSGrid
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class GridEntity : IGridEntity
    {
        [JsonIgnore]
        private JObject rawJObject;

        /// <summary>
        /// Gets the raw <see cref="JObject">JObject</see> exposed by the Newtonsoft.Json library.
        /// This can be used to access properties that are not directly exposed by MLSGrid's .Net
        /// library.
        /// </summary>
        /// <remarks>
        /// You should always prefer using the standard property accessors whenever possible. This
        /// accessor is not considered fully stable and might change or be removed in future
        /// versions.
        /// </remarks>
        /// <returns>The raw <see cref="JObject">JObject</see>.</returns>
        [JsonIgnore]
        public JObject RawJObject
        {
            get
            {
                // Lazily initialize the object the first time the getter is called.
                if (this.rawJObject == null)
                {
                    if (this.GridResponse == null)
                    {
                        return null;
                    }

                    this.rawJObject = JObject.Parse(this.GridResponse.Content);
                }

                return this.rawJObject;
            }

            protected set
            {
                this.rawJObject = value;
            }
        }

        [JsonIgnore]
        public GridResponse GridResponse { get; set; }

        /// <summary>
        /// Deserializes the JSON to a Grid object type. The type is automatically deduced from
        ///  the <c>object</c> key in the JSON string.
        /// </summary>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Grid object from the JSON string.</returns>
        public static IHasObject FromJson(string value)
        {
            return JsonUtils.DeserializeObject<IHasObject>(value, GridConfiguration.SerializerSettings);
        }

        /// <summary>Deserializes the JSON to the specified Grid object type.</summary>
        /// <typeparam name="T">The type of the Grid object to deserialize to.</typeparam>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Grid object from the JSON string.</returns>
        public static T FromJson<T>(string value)
            where T : IGridEntity
        {
            return JsonUtils.DeserializeObject<T>(value, GridConfiguration.SerializerSettings);
        }

        /// <summary>Reports a Grid object as a string.</summary>
        /// <returns>
        /// A string representing the Grid object, including its JSON serialization.
        /// </returns>
        /// <seealso cref="ToJson"/>
        public override string ToString()
        {
            return string.Format(
                "<{0}@{1} id={2}> JSON: {3}",
                this.GetType().FullName,
                RuntimeHelpers.GetHashCode(this),
                this.GetIdString(),
                this.ToJson());
        }

        /// <summary>Serializes the Grid object as a JSON string.</summary>
        /// <returns>An indented JSON string represensation of the object.</returns>
        public string ToJson()
        {
            return JsonUtils.SerializeObject(
                this,
                Formatting.Indented,
                GridConfiguration.SerializerSettings);
        }

        /// <summary>
        /// Sets a string ID on an expandable field. If the expandable field does not exist,
        /// a new one is initialized. If the expandable field exists and already contains an
        /// expanded object, and the ID within the expanded object does not match the new string ID,
        /// expanded object is discarded.
        /// </summary>
        /// <typeparam name="T">Type of the expanded object.</typeparam>
        /// <param name="id">The string ID.</param>
        /// <param name="expandable">The expandable field.</param>
        /// <returns>The expandable field with its ID set to the provided string ID.</returns>
        protected static ExpandableField<T> SetExpandableFieldId<T>(
            string id,
            ExpandableField<T> expandable)
            where T : IHasId
        {
            if (expandable == null)
            {
                expandable = new ExpandableField<T>();
                expandable.Id = id;
            }
            else if (expandable.Id != id)
            {
                expandable.ExpandedObject = default;
                expandable.Id = id;
            }

            return expandable;
        }

        /// <summary>
        /// Sets an expanded object on an expandable field. If the expandable field does not exist,
        /// a new one is initialized.
        /// </summary>
        /// <typeparam name="T">Type of the expanded object.</typeparam>
        /// <param name="obj">The expanded object.</param>
        /// <param name="expandable">The expandable field.</param>
        /// <returns>
        /// The expandable field with its expanded object set to the provided object.
        /// </returns>
        protected static ExpandableField<T> SetExpandableFieldObject<T>(
            T obj,
            ExpandableField<T> expandable)
            where T : IHasId
        {
            if (expandable == null)
            {
                expandable = new ExpandableField<T>();
            }

            expandable.ExpandedObject = obj;

            return expandable;
        }

        protected static List<ExpandableField<T>> SetExpandableArrayIds<T>(List<string> ids)
            where T : IHasId
        {
            return ids?.Select((id) =>
            {
                var expandable = new ExpandableField<T>();
                expandable.Id = id;
                return expandable;
            }).ToList();
        }

        protected static List<ExpandableField<T>> SetExpandableArrayObjects<T>(List<T> objects)
            where T : IHasId
        {
            return objects?.Select((obj) =>
            {
                var expandable = new ExpandableField<T>();
                expandable.Id = obj.Id;
                expandable.ExpandedObject = obj;
                return expandable;
            }).ToList();
        }

        private object GetIdString()
        {
            foreach (var property in this.GetType().GetTypeInfo().DeclaredProperties)
            {
                if (property.Name == "Id")
                {
                    return property.GetValue(this);
                }
            }

            return null;
        }
    }

    public abstract class GridEntity<T> : GridEntity
        where T : GridEntity<T>
    {
        /// <summary>Deserializes the JSON to a Grid object type.</summary>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Grid object from the JSON string.</returns>
        public static new T FromJson(string value)
        {
            return GridEntity.FromJson<T>(value);
        }
    }
}
