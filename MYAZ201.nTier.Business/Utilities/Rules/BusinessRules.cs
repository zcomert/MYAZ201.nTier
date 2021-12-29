using MYAZ201.nTier.Business.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business.Utilities.Rules
{
    public class BusinessRules
    {
        public static List<IResult> Apply(params IResult[] rules)
        {
            var results = new List<IResult>();
            foreach (var rule in rules)
                if (!rule.Success)
                    results.Add(rule);
            return results;
        }
    }
}
