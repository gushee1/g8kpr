using Grpc.Core;
using g8kpr.proto;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace g8kpr.services
{
    public class TrackManagerService : TrackManager.TrackManagerBase
    {
        public static string GetWavByName(string trackName) {
            // TODO: this actually needs to return the audio data?
            return "hello";
        }
        
        private static Tuple<int, int> GetTrackMetaData(string trackName) {
            // TODO: this needs to take as a param whatever GetWavByName returns
            return new Tuple<int, int>(300, 120);
        }

        private static void CreateDanceSequence(ref TrackInfo track) {
            // TODO: this is going to be the proprietary g8kpr algo
            track.Dance.AddRange([]);
        }

        public override Task<TrackInfo> GetTrackInfo(TrackInfoRequest request, ServerCallContext context)
        {
            var track = new TrackInfo();

            var audioData = GetWavByName(request.TrackName);
            var metadata = GetTrackMetaData(audioData);
            track.Duration = metadata.Item1;
            track.Bpm = metadata.Item2;
            CreateDanceSequence(ref track);

            return Task.FromResult(track);
        }
    }
}
