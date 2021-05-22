using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldRepetition : HL7V2FieldBase
    {
        public HL7V2FieldRepetition()
        {
            Components = new List<HL7V2Component>();
        }

        public override int Id { get; set; }

        public override string Delimiter { get; set; }

        public override string Value { get; set; }

        public override void Rebuild()
        {
            if (Components.Count > 0)
            {
                foreach (var component in Components)
                {
                    component.Rebuild();
                }

                Value = CombineHL7Fields(Components.Cast<HL7V2FieldBase>().ToList());
            }
        }

        public IList<HL7V2Component> Components { get; set; }

        #region Component Operations
        public void AddComponent(string value)
        {
            Components.Add(new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = Components.Count > 0 ? Components.Last().Id + 1 : 1,
                Value = value
            });
        }

        public void RemoveComponent(int id)
        {
            var component = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return;
            }

            Components.Remove(component);
        }

        public void InsertComponent(int id, string value)
        {
            if (id >= Components.Max(fr => fr.Id) || id <= 0)
            {
                return;
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
                return;
            }

            var currentIndex = Components.IndexOf(currentComponent);

            // increment the Ids of the components after
            foreach (var c in Components)
            {
                if (c.Id > currentIndex)
                {
                    c.Id++;
                }
            }

            Components.Insert(currentIndex, component);
        }

        public void UpdateComponent(int id, string value)
        {
            if (id >= Components.Max(fr => fr.Id) || id <= 0)
            {
                return;
            }

            var component = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return;
            }

            component.Value = value;
        }
        #endregion
    }
}