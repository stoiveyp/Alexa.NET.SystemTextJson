
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.NET.Request.Type
{
    public class AudioPlayerRequest: Request
    {
        [JsonPropertyName("token")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string Token { get; set; }

        [JsonPropertyName("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

        [JsonPropertyName("error")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public Error Error { get; set; }

        [JsonPropertyName("currentPlaybackState")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public PlaybackState CurrentPlaybackState { get; set; }

        [JsonPropertyName("enqueuedToken")][JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public string EnqueuedToken { get; set; }
        
        public bool HasEnqueuedItem
        {
            get
            {
                /*if (EnqueuedToken != null && EnqueuedToken != "")
                    return true;
                else
                    return false;
                    */
                return !String.IsNullOrEmpty(EnqueuedToken);
            }
        }

        public AudioRequestType AudioRequestType
        {
            get
            {
                switch (this.Type.Split('.')[1])
                {
                    case "PlaybackStarted":
                        return AudioRequestType.PlaybackStarted;
                    case "PlaybackFinished":
                        return AudioRequestType.PlaybackFinished;
                    case "PlaybackStopped":
                        return AudioRequestType.PlaybackStopped;
                    case "PlaybackNearlyFinished":
                        return AudioRequestType.PlaybackNearlyFinished;
                    case "PlaybackFailed":
                        return AudioRequestType.PlaybackFailed;
                    default:
                        return AudioRequestType.Unknown;
                }
            }
        }
    }
}
