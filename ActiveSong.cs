using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooBox;

namespace BooBoxClient {
	public static class ActiveSong {
		public static SongInfo SongInfo;
		public static byte[] SongData;

		public static void AppendSongData(byte[] newData) {
			Console.WriteLine(newData.ToString());
		}

	}
}
