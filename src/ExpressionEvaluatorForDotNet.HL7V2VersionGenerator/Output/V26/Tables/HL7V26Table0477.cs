using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0477
    {
        public string Id { get { return @"0477"; } }

        public string TableId { get { return @"0477"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Controlled Substance Schedule*"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Schedule I",
                            Comment = @"Includes drugs that have a high potential for abuse, no currently accepted medical use in the United States and a lack of accepted safety for use under medical supervision."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"II",
                            Description = @"Schedule II",
                            Comment = @"Includes drugs having currently accepted medical use in the United States and a high abuse potential, with severe psychological or physical dependence liability."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"III",
                            Description = @"Schedule III",
                            Comment = @"Includes drugs having an abuse potential less than that of drugs listed in Schedules I and II. All CS III drugs have a currently accepted medical use in the United States."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IV",
                            Description = @"Schedule IV",
                            Comment = @"Includes drugs having a lesser potential for abuse than those listed in Schedule III. CS IV drugs have a currently accepted medical use in the United States."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Schedule V",
                            Comment = @"Includes drugs having low abuse potential and limited physical or psychological dependence relative to those listed in IV and have an accepted medical use in the United States."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VI",
                            Description = @"Schedule VI",
                            Comment = @"State defined"
                        },
                    };
            } 
        }
    }
}
