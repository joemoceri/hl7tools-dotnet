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

        public HL7V2Component this[int id]
        {
            get
            {
                return Components.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

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

        public IList<HL7V2Component> Components { get; set; }

        #region Component Operations
        public HL7V2Component AddComponent(string value)
        {
            var result = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Id = Components.Count > 0 ? Components.Last().Id + 1 : 1,
                Value = value
            };

            Components.Add(result);

            return result;
        }

        public bool RemoveComponent(int id)
        {
            var component = Components.FirstOrDefault(c => c.Id.Equals(id));

            if (component == null)
            {
                return false;
            }

            return Components.Remove(component);
        }

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

            // increment the Ids of the components after
            foreach (var c in Components)
            {
                if (c.Id > currentIndex)
                {
                    c.Id++;
                }
            }

            Components.Insert(currentIndex, component);

            return component;
        }

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