using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// 
    /// </summary>
    public class HL7V2Component : HL7V2FieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public HL7V2Component()
        {
            SubComponents = new List<HL7V2SubComponent>();
        }

        /// <summary>
        /// 
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<HL7V2SubComponent> SubComponents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HL7V2SubComponent this[int id]
        {
            get
            {
                return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HL7V2SubComponent GetSubComponent(int id)
        {
            return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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