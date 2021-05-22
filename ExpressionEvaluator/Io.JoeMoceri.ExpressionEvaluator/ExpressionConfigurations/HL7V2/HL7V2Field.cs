using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Field : HL7V2FieldBase
    {
        public HL7V2Field()
        {
            FieldRepetitions = new List<HL7V2FieldRepetition>();
        }

        public override int Id { get; set; }

        public override string Delimiter { get; set; }

        public override string Value { get; set; }

        public IList<HL7V2FieldRepetition> FieldRepetitions { get; set; }

        public HL7V2FieldRepetition GetFieldRepetition(int id)
        {
            return FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));
        }

        public IList<HL7V2Component> Components(int repetition = 1)
        {
            return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetition))?.Components;
        }

        public HL7V2Component GetComponent(int id, int repetition = 1)
        {
            return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetition))?.Components?.FirstOrDefault(f => f.Id.Equals(id));
        }

        public override void Rebuild()
        {
            if (FieldRepetitions.Count > 0)
            {
                foreach (var fieldRepetition in FieldRepetitions)
                {
                    fieldRepetition.Rebuild();
                }

                Value = CombineHL7Fields(FieldRepetitions.Cast<HL7V2FieldBase>().ToList());
            }
        }

        public HL7V2Component this[int id, int repetition = 1]
        {
            get
            {
                return FieldRepetitions?.FirstOrDefault(fr => fr.Id.Equals(repetition))?.Components?.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

        #region Field Component Operations
        public void AddComponent(string value, int repetition = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return;
            }

            fieldRepetition.Components.Add(new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = fieldRepetition.Components.Count > 0 ? fieldRepetition.Components.Last().Id + 1 : 1,
                Value = value
            });
        }

        public void RemoveComponent(int id, int repetition = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return;
            }

            var component = fieldRepetition.Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return;
            }

            fieldRepetition.Components.Remove(component);
        }

        public void InsertComponent(int id, string value, int repetition = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return;
            }

            if (id >= fieldRepetition.Components.Max(fr => fr.Id) || id <= 0)
            {
                return;
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
                return;
            }

            var currentIndex = fieldRepetition.Components.IndexOf(currentComponent);

            // increment the Ids of the components after
            foreach (var c in fieldRepetition.Components)
            {
                if (c.Id > currentIndex)
                {
                    c.Id++;
                }
            }

            fieldRepetition.Components.Insert(currentIndex, component);
        }

        public void UpdateComponent(int id, string value, int repetition = 1)
        {
            var fieldRepetition = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(repetition));

            if (fieldRepetition == null)
            {
                return;
            }

            if (id >= fieldRepetition.Components.Max(fr => fr.Id) || id <= 0)
            {
                return;
            }

            var component = fieldRepetition.Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return;
            }

            component.Value = value;
        }
        #endregion

        #region Field Repetition Operations
        public HL7V2FieldRepetition AddFieldRepetition(string value)
        {
            var result = new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = FieldRepetitions.Count > 0 ? FieldRepetitions.Last().Id + 1 : 1,
                Value = value,
            };

            FieldRepetitions.Add(result);

            return result;
        }

        public HL7V2FieldRepetition RemoveFieldRepetition(int id)
        {
            var fr = FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return fr;
            }

            FieldRepetitions.Remove(fr);

            return fr;
        }

        public HL7V2FieldRepetition InsertFieldRepetition(int id, string value)
        {
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

            foreach (var f in FieldRepetitions)
            {
                if (f.Id > previousIndex)
                {
                    f.Id++;
                }
            }

            FieldRepetitions.Insert(previousIndex, fieldRepetition);

            return fieldRepetition;
        }

        public HL7V2FieldRepetition UpdateFieldRepetition(int id, string value)
        {
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