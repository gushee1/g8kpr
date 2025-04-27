using System.Numerics;
using Grpc.Core;
using g8kpr.proto;

namespace g8kpr.services {
    public struct Track {
        public int duration;
        public int bpm;
        public Vector<bool> dance;
    }

    public class Testmanager {
        public static string GetWavByName(string trackName) {
            // TODO: this actually needs to return the audio data?
            return "hello";
        }

        private static Tuple<int, int> GetTrackMetaData(string trackName) {
            // TODO: this needs to take as a param whatever GetWavByName returns
            return new Tuple<int, int>(0, 0);
        }

        private static void CreateDanceSequence(ref Track track) {
            // TODO: this is going to be the proprietary g8kpr algo
            track.dance = new Vector<bool>();
        }

        public static Track GetTrackByName(string trackName) {
            // TODO: this is going to be the .NET entrypoint (called from game code)
            var track = new g8kpr.services.Track();
            var audioData = GetWavByName(trackName);
            var metadata = GetTrackMetaData(audioData);
            track.duration = metadata.Item1;
            track.bpm = metadata.Item2;
            CreateDanceSequence(ref track);
            return track;
        }
    }
}
