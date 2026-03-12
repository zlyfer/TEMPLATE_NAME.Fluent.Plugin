using Blast.API.Core.Processes;
using Blast.API.Processes;
using Blast.Core;
using Blast.Core.Interfaces;
using Blast.Core.Objects;
using Blast.Core.Results;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace TEMPLATE_NAME.Fluent.Plugin
{
    public class TEMPLATE_NAMESearchApp : ISearchApplication
    {
        private const string SearchAppName = "TEMPLATE_SEARCH_APP";
        private readonly List<SearchTag> _searchTags;
        private readonly SearchApplicationInfo _applicationInfo;
        private readonly List<ISearchOperation> _supportedOperations;
        private List<string> _TEMPLATE_SEARCH_RESULT_LISTs = new();

        public TEMPLATE_NAMESearchApp()
        {
            _searchTags = new List<SearchTag>
            {
            };

            _supportedOperations = new List<ISearchOperation>
            {
                TEMPLATE_SEARCH_RESULT_OPERATION_NAMESearchOperation.TEMPLATE_SEARCH_RESULT_OPERATION_NAMEOperation
            };

            _applicationInfo = new SearchApplicationInfo(SearchAppName,
                "TEMPLATE_DESC",
                _supportedOperations)
            {
                MinimumSearchLength = 1,
                IsProcessSearchEnabled = false,
                IsProcessSearchOffline = true,
                ApplicationIconGlyph = "\uf003",
                SearchAllTime = ApplicationSearchTime.Fast,
                DefaultSearchTags = _searchTags
            };
        }

        public ValueTask LoadSearchApplicationAsync()
        {
            // TODO: Call to function that populates '_TEMPLATE_SEARCH_RESULT_LISTs' or do it in 'SearchAsync' to dynamically get the results:
            return ValueTask.CompletedTask;
        }

        public SearchApplicationInfo GetApplicationInfo()
        {
            return _applicationInfo;
        }

        /// <summary>
        /// <TODO: Describe the search logic.>
        /// </summary>
        public async IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest searchRequest,
            [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            // TODO: Call to function that populates '_TEMPLATE_SEARCH_RESULT_LISTs' or do it in 'LoadSearchApplicationAsync' to statically get the results:
            if (cancellationToken.IsCancellationRequested || searchRequest.SearchType == SearchType.SearchProcess)
                yield break;

            string searchedText = searchRequest.SearchedText.ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(searchedText))
                yield break;

            // TODO: Implement search logic by using 'searchedText' to find results in '_TEMPLATE_SEARCH_RESULT_LISTs':
        }

        /// <summary>
        /// Handle the selected result.
        /// TEMPLATE_SEARCH_RESULT_OPERATION_NAMESearchOperation: <TODO: Describe the operation.>
        /// </summary>
        public ValueTask<IHandleResult> HandleSearchResult(ISearchResult searchResult)
        {
            if (searchResult is not TEMPLATE_SEARCH_RESULT_NAMESearchResult result)
            {
                return new ValueTask<IHandleResult>(new HandleResult(false, false));
            }

            switch (searchResult.SelectedOperation)
            {
                case TEMPLATE_SEARCH_RESULT_OPERATION_NAMESearchOperation:
                    // TODO: Implement search result operation using 'result':

                    return new ValueTask<IHandleResult>(new HandleResult(true, false));
                default:
                    return new ValueTask<IHandleResult>(new HandleResult(false, false));
            }
        }
    }
}
