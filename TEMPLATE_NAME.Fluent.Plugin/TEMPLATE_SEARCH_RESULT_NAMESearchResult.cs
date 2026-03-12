using Blast.Core.Interfaces;
using Blast.Core.Results;
using System.Collections.Generic;

namespace TEMPLATE_NAME.Fluent.Plugin
{
    public sealed class TEMPLATE_SEARCH_RESULT_NAMESearchResult : SearchResultBase
    {
        public TEMPLATE_SEARCH_RESULT_NAMESearchResult(
                string searchAppName,
                string searchedText,
                double score,
                IList<ISearchOperation> supportedOperations,
                ICollection<SearchTag> tags,
                string TEMPLATE_SEARCH_RESULT_LIST
            ) : base(
                searchAppName,
                searchedText,
                score,
                supportedOperations,
                tags,
                "TEMPLATE_SEARCH_RESULT_DISPLAYNAME",
                TEMPLATE_SEARCH_RESULT_LIST
            )
        {
            TEMPLATE_SEARCH_RESULT_LIST = TEMPLATE_SEARCH_RESULT_LIST;

            MlFeatures = new Dictionary<string, string>
            {
                ["TEMPLATE_SEARCH_RESULT_LIST"] = TEMPLATE_SEARCH_RESULT_LIST
            };
        }

        public string TEMPLATE_SEARCH_RESULT_LIST { get; }

        protected override void OnSelectedSearchResultChanged()
        {
        }
    }
}
