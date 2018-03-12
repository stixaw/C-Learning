using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
	public class VideoService
	{
		private IFileReader _fileReader;
		private IVideoRepository _repository;

		public VideoService(IFileReader fileReader = null, IVideoRepository repository = null)
		{
			_fileReader = fileReader ?? new FileReader();
			_repository = repository ?? new VideoRepository();
		}

		public string ReadVideoTitle()
		{
			//this code needs to be decoupled into its seperate class
			var str = _fileReader.Reader("video.txt");
			var video = JsonConvert.DeserializeObject<Video>(str);
			if (video == null)
				return "Error parsing the video.";
			return video.Title;
		}

		// [] => ""
		// [{}, {}, {}] => "1,2,3"
		public string GetUnprocessedVideosAsCsv()
		{
			var videoIds = new List<int>();

			// External resource
			//var videos =
			//	(from video in context.Videos
			//	 where !video.IsProcessed
			//	 select video).ToList();

			var videos = _repository.GetUnproccessedVideos();

			foreach (var v in videos)
				videoIds.Add(v.Id);

			return String.Join(",", videoIds);

		}
	}

	public class Video
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public bool IsProcessed { get; set; }
	}

	public class VideoContext : DbContext
	{
		public DbSet<Video> Videos { get; set; }
	}
}