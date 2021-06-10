using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// This class refers to HL7V2 Components defined in V2 specification. Components exist inside fields and their repetitions.
    /// </summary>
    public class HL7V2Component : HL7V2FieldBase
    {
        /// <summary>
        /// Initializes the <see cref="SubComponents"/>
        /// </summary>
        public HL7V2Component()
        {
            SubComponents = new List<HL7V2SubComponent>();
        }

        /// <summary>
        /// The <see cref="Id"/> of the component is the position. 1-based.
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// The delimiter is used to <see cref="Rebuild"/> the component. It's the same as the <see cref="HL7V2ExpressionConfiguration.componentDelimiter"/>.
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// The <see cref="Value"/> of the component.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// The <see cref="SubComponents"/> inside the component, if any.
        /// </summary>
        public IList<HL7V2SubComponent> SubComponents { get; set; }

        /// <summary>
        /// Get a <see cref="HL7V2SubComponent"/> by <see cref="Id"/> via indexer.
        /// </summary>
        /// <param name="id">The <see cref="Id"/> of the component.</param>
        /// <returns><see cref="HL7V2SubComponent"/></returns>
        public HL7V2SubComponent this[int id]
        {
            get
            {
                return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
            }
        }

        /// <summary>
        /// Get a <see cref="HL7V2SubComponent"/> by <see cref="Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="Id"/> of the component.</param>
        /// <returns><see cref="HL7V2SubComponent"/></returns>
        public HL7V2SubComponent GetSubComponent(int id)
        {
            return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
        }

        /// <summary>
        /// Rebuild's the <see cref="Value"/> by first calling <see cref="HL7V2SubComponent.Rebuild"/> on each <see cref="HL7V2SubComponent"/>, then combines those values, and set's it equal to this <see cref="Value"/>.
        /// </summary>
        public override void Rebuild()
        {
            if (SubComponents.Count > 0)
            {
                for (var i = 0; i < SubComponents.Count; i++)
                {
                    SubComponents[i].Id = i + 1;
                }

                Value = CombineHL7Fields(SubComponents.Cast<HL7V2FieldBase>().ToList());
            }
        }

        #region SubComponent Operations
        /// <summary>
        /// Add's a <see cref="HL7V2SubComponent"/> to this <see cref="HL7V2Component"/> <see cref="SubComponents"/>. 
        /// </summary>
        /// <param name="value">The value that will be set to this <see cref="HL7V2Component"/> <see cref="Value"/>.</param>
        /// <returns><see cref="HL7V2SubComponent"/> if successful, <see cref="null"/> otherwise.</returns>
        public HL7V2SubComponent AddSubComponent(string value)
        {
            var result = new HL7V2SubComponent
            {
                Delimiter = HL7V2ExpressionConfiguration.subComponentDelimiter,
                Id = SubComponents.Count > 0 ? SubComponents.Last().Id + 1 : 1,
                Value = value
            };

            SubComponents.Add(result);

            return result;
        }

        /// <summary>
        /// Removes a <see cref="HL7V2SubComponent"/> by <see cref="Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="Id"/>.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveSubComponent(int id)
        {
            var subComponent = SubComponents.FirstOrDefault(c => c.Id.Equals(id));

            if (subComponent == null)
            {
                return false;
            }

            return SubComponents.Remove(subComponent);
        }

        /// <summary>
        /// Inserts a <see cref="HL7V2SubComponent"/> by <see cref="HL7V2SubComponent.Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="Id"/> you wish to insert at.</param>
        /// <param name="value">The <see cref="HL7V2SubComponent.Value"/>.</param>
        /// <returns><see cref="HL7V2SubComponent"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2SubComponent InsertSubComponent(int id, string value)
        {
            if (id >= SubComponents.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var subComponent = new HL7V2SubComponent
            {
                Delimiter = HL7V2ExpressionConfiguration.subComponentDelimiter,
                Id = id,
                Value = value
            };

            var currentSubComponent = SubComponents.FirstOrDefault(c => c.Id.Equals(id));

            if (currentSubComponent == null)
            {
                return null;
            }

            var currentIndex = SubComponents.IndexOf(currentSubComponent);

            // increment the Ids after
            foreach (var sc in SubComponents)
            {
                if (sc.Id > currentIndex)
                {
                    sc.Id++;
                }
            }

            SubComponents.Insert(currentIndex, subComponent);

            return subComponent;
        }

        /// <summary>
        /// Updates a <see cref="HL7V2SubComponent"/> by <see cref="HL7V2SubComponent.Id"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2SubComponent.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2SubComponent.Value"/>.</param>
        /// <returns><see cref="HL7V2SubComponent"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2SubComponent UpdateSubComponent(int id, string value)
        {
            if (id >= SubComponents.Max(sc => sc.Id) || id <= 0)
            {
                return null;
            }

            var subComponent = SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));

            if (subComponent == null)
            {
                return null;
            }

            subComponent.Value = value;

            return subComponent;
        }
        #endregion
    }
}