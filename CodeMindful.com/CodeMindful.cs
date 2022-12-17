using System;
using System.Collections.Generic;

namespace CodeMindful.Pattern
{
    internal class CodeMindful
    {
        public void Process(IEnumerable<Observation> observations)
        {
            foreach (var observation in observations)
            {
                if (observation.Impact.HasValue)
                    Notice(observation);
                else
                    Release(observation);
            }
        }

        private void Notice(Observation observation)
        {
        }

        private void Release(Observation observation)
        {
        }
    }

    public enum Impact
    {
        Negative = -1,
        None = 0,
        Important,
    }

    public class Observation
    {
        public Guid Id { get; }
        public IList<string> Labels { get; }
        public Impact? Impact { get; set; }
    }
}
