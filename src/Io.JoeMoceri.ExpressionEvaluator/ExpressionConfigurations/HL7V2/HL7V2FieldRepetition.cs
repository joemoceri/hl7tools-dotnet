using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// This class refers to HL7V2 Field Repetitions defined in V2 specification. Field Repetitions exist within fields. You always have atleast one FieldRepetition if there's a Field, unless it's a special case, such as MSH.1.
    /// </summary>
    public class HL7V2FieldRepetition : HL7V2FieldBase
    {
        /// <summary>
        /// Initializes the <see cref="Components"/>.
        /// </summary>
        public HL7V2FieldRepetition()
        {
            Components = new List<HL7V2Component>();
        }

        /// <summary>
        /// The Id of the Field Repetition.
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// The Delimiter of the Field Repetition. This is the same as <see cref="HL7V2ExpressionConfiguration.fieldRepetitionDelimiter"/>.
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// The value of the Field Repetition.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// A list of <see cref="HL7V2Component"/>'s for this Field Repetition.
        /// </summary>
        public IList<HL7V2Component> Components { get; set; }
        
        /// <summary>
        /// Get a <see cref="HL7V2Component"/> by it's <see cref="HL7V2Component.Id"/> via indexer.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if found, otherwise <see cref="null"/>.</returns>
        public HL7V2Component this[int id]
        {
            get
            {
                return Components.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

        /// <summary>
        /// Rebuild this Field Repetitions <see cref="Value"/> first by calling <see cref="HL7V2Component.Rebuild"/> on it's <see cref="Components"/>, then combine those and set it to this <see cref="Value"/>.
        /// </summary>
        public override void Rebuild()
        {
            if (Components.Count > 0)
            {
                for (var i = 0; i < Components.Count; i++)
                {
                    Components[i].Rebuild();
                    Components[i].Id = i + 1;
                }

                Value = CombineHL7Fields(Components.Cast<HL7V2FieldBase>().ToList());
            }
        }

        /// <summary>
        /// Gets a <see cref="HL7V2Component"/> on this field repetition by <see cref="HL7V2Component.Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if found, otherwise <see cref="null"/>.</returns>
        public HL7V2Component GetComponent(int id)
        {
            return Components.FirstOrDefault(f => f.Id.Equals(id));
        }

        #region Component Operations
        /// <summary>
        /// Adds a <see cref="HL7V2Component"/> to this Field Repetitions <see cref="Components"/>.
        /// </summary>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component AddComponent(string value)
        {
            var result = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = Components.Count > 0 ? Components.Last().Id + 1 : 1,
                Value = value
            };

            if (value.Contains(HL7V2ExpressionConfiguration.subComponentDelimiter))
            {
                var subComponents = result.Value.Split(HL7V2ExpressionConfiguration.subComponentDelimiter);
                for (var i = 0; i < subComponents.Length; i++)
                {
                    result.AddSubComponent(subComponents[i]);
                }
            }

            Components.Add(result);

            return result;
        }

        /// <summary>
        /// Removes a <see cref="HL7V2Component"/> from this Field Repetitions <see cref="Components"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveComponent(int id)
        {
            var component = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return false;
            }

            var result = Components.Remove(component);

            Rebuild();

            return result;
        }

        /// <summary>
        /// Inserts a <see cref="HL7V2Component"/> into this Field Repetitions <see cref="Components"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component InsertComponent(int id, string value)
        {
            if (id >= Components.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var component = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = id,
                Value = value
            };

            var currentComponent = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (currentComponent == null)
            {
                return null;
            }

            var currentIndex = Components.IndexOf(currentComponent);

            Components.Insert(currentIndex, component);

            Rebuild();

            return component;
        }

        /// <summary>
        /// Updates a <see cref="HL7V2Component"/> in this Field Repetitions <see cref="Components"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component UpdateComponent(int id, string value)
        {
            if (id >= Components.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var component = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return null;
            }

            component.Value = value;

            return component;
        }
        #endregion
    }
}