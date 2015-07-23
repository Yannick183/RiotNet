﻿using RestSharp;
using RiotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet
{
    public partial class RiotClient
    {
        private IRestRequest GetMatchHistoryRequest(long summonerId, long[] championIds, RankedQueue[] rankedQueues, int? beginIndex, int? endIndex)
        {
            var request = Get("api/lol/{region}/v2.2/matchhistory/{summonerId}");
            request.AddUrlSegment("summonerId", summonerId.ToString());
            request.AddQueryParameter("championIds", String.Join(",", championIds));
            request.AddQueryParameter("rankedQueues", String.Join(",", rankedQueues));
            if (beginIndex != null)
            {
                request.AddQueryParameter("beginIndex", beginIndex.ToString());
            }
            if (endIndex != null)
            {
                request.AddQueryParameter("endIndex", endIndex.ToString());
            }
            return request;
        }

        /// <summary>
        /// Gets the match history for a summoner.
        /// </summary>
        /// <param name="summonerId">The summoner's summoner IDs.</param>
        /// <param name="championIds">Only get games where the summoner played one of these champions.</param>
        /// <param name="rankedQueues">Only get games from these ranked queues.</param>
        /// <param name="beginIndex">The begin index to use for fetching games.</param>
        /// <param name="endIndex">The end index to use for fetching games. The maximum allowed difference between beginIndex and endIndex; if it is larger than 15, endIndex will be modified to satisfy this restriction.</param>
        /// <returns>The match history for the summoner.</returns>
        public PlayerHistory GetMatchHistory(long summonerId, long[] championIds, RankedQueue[] rankedQueues, int beginIndex, int endIndex)
        {
            return Execute<PlayerHistory>(GetMatchHistoryRequest(summonerId, championIds, rankedQueues, beginIndex, endIndex));
        }

        /// <summary>
        /// Gets the match history for a summoner.
        /// </summary>
        /// <param name="summonerId">The summoner's summoner IDs.</param>
        /// <param name="championIds">Only get games where the summoner played one of these champions.</param>
        /// <param name="rankedQueues">Only get games from these ranked queues.</param>
        /// <param name="beginIndex">The begin index to use for fetching games.</param>
        /// <param name="endIndex">The end index to use for fetching games. The maximum allowed difference between beginIndex and endIndex; if it is larger than 15, endIndex will be modified to satisfy this restriction.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task<PlayerHistory> GetMatchHistoryTaskAsync(long summonerId, long[] championIds, RankedQueue[] rankedQueues, int beginIndex, int endIndex)
        {
            return ExecuteTaskAsync<PlayerHistory>(GetMatchHistoryRequest(summonerId, championIds, rankedQueues, beginIndex, endIndex));
        }
    }
}