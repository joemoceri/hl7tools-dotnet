using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This class refers to HL7V2 Fields defined in V2 specification. Fields are the highest level of 'fields' in an HL7V2 message segment.
    /// </summary>
    public class HL7V2Field : HL7V2FieldBase
    {
        /// <summary>
        /// Initializes the <see cref="FieldRepetitions"/>.
        /// </summary>
        public HL7V2Field()
        {
            FieldRepetitions = new List<HL7V2FieldRepetition>();
        }

        /// <summary>
        /// The Id of the field. 1-based.
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// The <see cref="Delimiter"/> of the field. This is the same as <see cref="HL7V2ExpressionConfiguration.fieldDelimiter"/>.
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// The value of the field.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// A list of the field's <see cref="HL7V2FieldRepetition"/>'s, if any.
        /// </summary>
        public IList<HL7V2FieldRepetition> FieldRepetitions { get; set; }

        /// <summary>
        /// Get a <see cref="HL7V2FieldRepetition"/> by <see cref="HL7V2FieldRepetition.Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <returns><see cref="HL7V2FieldRepetition"/>if found, otherwise <see cref="null"/>.</returns>
        public HL7V2FieldRepetition GetFieldRepetition(int id)
        {
            return FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));
        }

        /// <summary>
        /// Gets a list of this Fields <see cref="HL7V2Component"/>'s. By default it references the first repetition.
        /// </summary>
        /// <param name="repetitionId">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <returns><see cref="IList{HL7V2Component}"/>if found, otherwise <see cref="null"/>.</returns>
        public IList<HL7V2Component> Components(int repetitionId = 1)
        {
            return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetitionId))?.Components;
        }

        /// <summary>
        /// Gets a <see cref="HL7V2Component"/> on this field if it exists by <see cref="HL7V2Component.Id"/> and <see cref="HL7V2FieldRepetition.Id"/> (default 1).
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="repetitionId">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <returns><see cref="HL7V2Component"/> if found, otherwise <see cref="null"/>.</returns>
        public HL7V2Component GetComponent(int id, int repetitionId = 1)
        {
            return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetitionId))?.Components?.FirstOrDefault(f => f.Id.Equals(id));
        }

        /// <summary>
        /// Rebuild this Fields <see cref="Value"/> first by calling <see cref="HL7V2FieldRepetition.Rebuild"/> on it's <see cref="FieldRepetitions"/>, then combining those fields and setting it to <see cref="Value"/>.
        /// </summary>
        public override void Rebuild()
        {
            if (FieldRepetitions.Count > 0)
            {
                for (var i = 0; i < FieldRepetitions.Count; i++)
                {
                    FieldRepetitions[i].Rebuild();
                    FieldRepetitions[i].Id = i + 1;
                }

                Value = CombineHL7Fields(FieldRepetitions.Cast<HL7V2FieldBase>().ToList());
            }
        }

        /// <summary>
        /// Get a <see cref="HL7V2Component"/> by <see cref="HL7V2Component.Id"/> and <see cref="HL7V2FieldRepetition.Id"/> (default 1) via indexer.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="repetitionId">The <see cref="HL7V2FieldRepetition.Id"/>. Default is 1.</param>
        /// <returns><see cref="HL7V2Component"/> if found, otherwise <see cref="null"/>.</returns>
        public HL7V2Component this[int id, int repetitionId = 1]
        {
            get
            {
                return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetitionId))?.Components?.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

        #region Component Operations
        /// <summary>
        /// Add's a <see cref="HL7V2Component"/> to this Fields <see cref="Components(int)"/> by it's <see cref="HL7V2FieldRepetition.Id"/>. Default repetitionId is 1.
        /// </summary>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <param name="repetitionId">The <see cref="HL7V2FieldRepetition.Id"/>. Default is 1.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component AddComponent(string value, int repetitionId = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetitionId));

            if (fieldRepetition == null)
            {
                return null;
            }

            var result = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = fieldRepetition.Components.Count > 0 ? fieldRepetition.Components.Last().Id + 1 : 1,
                Value = value
            };

            if (!string.IsNullOrWhiteSpace(result.Value))
            {
                var subComponents = result.Value.Split(HL7V2ExpressionConfiguration.subComponentDelimiter);
                for (var i = 0; i < subComponents.Length; i++)
                {
                    result.AddSubComponent(subComponents[i]);
                }
            }

            fieldRepetition.Components.Add(result);

            return result;
        }

        /// <summary>
        /// Remove's a <see cref="HL7V2Component"/> from this Fields <see cref="Components(int)"/> by it's <see cref="HL7V2FieldRepetition.Id"/>. Default repetitionId is 1.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="repetitionId">The <see cref="HL7V2FieldRepetition.Id"/>. Default is 1.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveComponent(int id, int repetitionId = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetitionId));

            if (fieldRepetition == null)
            {
                return false;
            }

            var component = fieldRepetition.Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return false;
            }

            var result = fieldRepetition.Components.Remove(component);

            Rebuild();

            return result;
        }

        /// <summary>
        /// Insert's a <see cref="HL7V2Component"/> into this Fields <see cref="Components(int)"/> by it's <see cref="HL7V2FieldRepetition.Id"/>. Default repetitionId is 1.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <param name="repetition">The <see cref="HL7V2FieldRepetition.Id"/>. Default is 1.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component InsertComponent(int id, string value, int repetition = 1)
        {
            if (FieldRepetitions.Count == 0)
            {
                return null;
            }

            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return null;
            }

            if (fieldRepetition.Components.Count == 0)
            {
                return null;
            }

            if (id >= fieldRepetition.Components.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var component = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = id,
                Value = value
            };

            var currentComponent = fieldRepetition.Components.FirstOrDefault(c => c.Id.Equals(id));

            if (currentComponent == null)
            {
                return null;
            }

            var currentIndex = fieldRepetition.Components.IndexOf(currentComponent);

            fieldRepetition.Components.Insert(currentIndex, component);

            Rebuild();

            return component;
        }

        /// <summary>
        /// Update's a <see cref="HL7V2Component"/> from this Fields <see cref="Components(int)"/> by it's <see cref="HL7V2FieldRepetition.Id"/>. Default repetitionId is 1.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Component.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Component.Value"/>.</param>
        /// <param name="repetition">The <see cref="HL7V2FieldRepetition.Id"/>. Default is 1.</param>
        /// <returns><see cref="HL7V2Component"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Component UpdateComponent(int id, string value, int repetition = 1)
        {
            if (FieldRepetitions.Count == 0)
            {
                return null;
            }

            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return null;
            }

            if (fieldRepetition.Components.Count == 0)
            {
                return null;
            }

            if (id >= fieldRepetition.Components.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var component = fieldRepetition.Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return null;
            }

            component.Value = value;

            return component;
        }
        #endregion

        #region Field Repetition Operations
        /// <summary>
        /// Adds a <see cref="HL7V2FieldRepetition"/> to this Fields <see cref="FieldRepetitions"/>.
        /// </summary>
        /// <param name="value">The <see cref="HL7V2FieldRepetition.Value"/>.</param>
        /// <returns><see cref="HL7V2FieldRepetition"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2FieldRepetition AddFieldRepetition(string value)
        {
            var result = new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = FieldRepetitions.Count > 0 ? FieldRepetitions.Last().Id + 1 : 1,
                Value = value,
            };

            if (value.Contains(HL7V2ExpressionConfiguration.componentDelimiter))
            {
                var components = result.Value.Split(HL7V2ExpressionConfiguration.componentDelimiter);
                for (var i = 0; i < components.Length; i++)
                {
                    result.AddComponent(components[i]);
                }
            }

            FieldRepetitions.Add(result);

            return result;
        }

        /// <summary>
        /// Removes a <see cref="HL7V2FieldRepetition"/> from this Fields <see cref="FieldRepetitions"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveFieldRepetition(int id)
        {
            var fr = FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return false;
            }

            var result = FieldRepetitions.Remove(fr);

            Rebuild();

            return result;
        }

        /// <summary>
        /// Inserts a <see cref="HL7V2FieldRepetition"/> into this Fields <see cref="FieldRepetitions"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2FieldRepetition.Value"/>.</param>
        /// <returns><see cref="HL7V2FieldRepetition"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2FieldRepetition InsertFieldRepetition(int id, string value)
        {
            if (FieldRepetitions.Count == 0)
            {
                return null;
            }

            if (id >= FieldRepetitions.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var fieldRepetition = new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = id,
                Value = value
            };

            var pFr = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));

            if (pFr == null)
            {
                return pFr;
            }

            var previousIndex = FieldRepetitions.IndexOf(pFr);

            FieldRepetitions.Insert(previousIndex, fieldRepetition);

            Rebuild();

            return fieldRepetition;
        }

        /// <summary>
        /// Updates a <see cref="HL7V2FieldRepetition"/> from this Fields <see cref="FieldRepetitions"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2FieldRepetition.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2FieldRepetition.Value"/>.</param>
        /// <returns><see cref="HL7V2FieldRepetition"/> if successful, otherwise <see cref="null"/>;</returns>
        public HL7V2FieldRepetition UpdateFieldRepetition(int id, string value)
        {
            if (FieldRepetitions.Count == 0)
            {
                return null;
            }

            if (id >= FieldRepetitions.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var fr = FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return null;
            }

            fr.Value = value;

            return fr;
        }
        #endregion
    }
}