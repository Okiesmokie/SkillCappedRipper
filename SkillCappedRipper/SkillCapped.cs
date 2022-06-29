using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace SkillCappedRipper {
    public class SkillCapped {
        public SkillCapped() {
        }

        public string VideoPath = "videos/";

        private string lastErrorMessage = "";

        public bool GeneratePlaylist(string uri) {
            // Validate Uri
            try {
                var uriParse = new Uri(uri);

                if(uriParse.DnsSafeHost != "www.skill-capped.com") {
                    lastErrorMessage = $"Incorrect host name: {uriParse.DnsSafeHost} - Should be: www.skill-capped.com";
                    return false;
                }
            } catch(UriFormatException e) {
                lastErrorMessage = $@"{e.Message} (Missing https://?)";
                return false;
            }

            var uriFormat = "https://d13z5uuzt1wkbz.cloudfront.net/{0}/HIDDEN4500-{1}.ts";

            if(!RemoteFileExists(uri)) {
                lastErrorMessage = "No video exists at that URL";
                return false;
            }

            var uriParts = uri.Split("/");
            var videoID = uriParts[uriParts.Length - 1];
            var fileName = uriParts[uriParts.Length - 2] + ".m3u8";

            using(var fp = File.CreateText(VideoPath + fileName)) {
                // Write M3U headers
                fp.WriteLine("#EXTM3U");
                fp.WriteLine("#EXT-X-PLAYLIST-TYPE:VOD");
                fp.WriteLine("#EXT-X-TARGETDURATION:10");

                for(int i = 1; ; ++i) {
                    var partFileName = string.Format(uriFormat, videoID, i.ToString().PadLeft(5, '0'));

                    if(RemoteFileExists(partFileName)) {
                        fp.WriteLine(partFileName);
                    } else {
                        break;
                    }
                }

                fp.WriteLine("#EXT-X-ENDLIST");
            }

            return true;
        }
        public string GetLastError() {
            return lastErrorMessage;
        }

        private bool RemoteFileExists(string uri) {
            using(var httpClient = new HttpClient()) {
                try {
                    var response = httpClient.Send(new HttpRequestMessage(HttpMethod.Head, uri));

                    return response.StatusCode == System.Net.HttpStatusCode.OK;
                } catch(Exception) {
                    return false;
                }
            }
        }
    }
}
