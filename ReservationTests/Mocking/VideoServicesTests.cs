using TestNinja.Mocking;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace TestNinja.UnitTests.Mocking
{
	[TestFixture]
	public class VideoServicesTests
	{


		//[Test] //Dependency via Method Parameter
		//public void ReadVideoTitle_EmptyFile_ReturnError()
		//{
		//	var service = new VideoService();

		//	var result = service.ReadVideoTitle(new FakeFileReader());

		//	Assert.That(result, Does.Contain("error").IgnoreCase);
		//}

		//[Test] // Dependency Via Properties
		//public void ReadVideoTitle_EmptyFile_ReturnError()
		//{
		//	var service = new VideoService();
		//	service.FileReader = new FakeFileReader();

		//	var result = service.ReadVideoTitle();

		//	Assert.That(result, Does.Contain("error").IgnoreCase);
		//}

		//[Test]// Dependency by Constructor
		//public void ReadVideoTitle_EmptyFile_ReturnError()
		//{
		//	var service = new VideoService(new FakeFileReader());

		//	var result = service.ReadVideoTitle();

		//	Assert.That(result, Does.Contain("error").IgnoreCase);
		//}

		private VideoService _videoservice;
		private Mock<IFileReader> _fileReader;
		private Mock<IVideoRepository> _videoRepository;

		[SetUp]
		public void SetUp()
		{
			_fileReader = new Mock<IFileReader>();
			_videoRepository = new Mock<IVideoRepository>();
			_videoservice = new VideoService(_fileReader.Object, _videoRepository.Object);
		}

		[Test]// Using MOQ
		public void ReadVideoTitle_EmptyFile_ReturnError()
		{
			_fileReader.Setup(fr => fr.Reader("video.txt")).Returns("");

			var result = _videoservice.ReadVideoTitle();

			Assert.That(result, Does.Contain("error").IgnoreCase);
		}

		[Test]
		public void GetUnprocessedVideoAsCsv_AllVideosAreProcessed_ReturnEmptyString()
		{
			//Arrange
			_videoRepository.Setup(r => r.GetUnproccessedVideos()).Returns(new List<Video>());

			//Act
			var result = _videoservice.GetUnprocessedVideosAsCsv();

			//Assert
			Assert.That(result, Is.EqualTo(""));
		}

		[Test]
		public void GetUnprocessedVideoAsCsv_VideosProcessed_ReturnStringWithIDOFUnProcessedVideos()
		{
			//Arrange
			_videoRepository.Setup(r => r.GetUnproccessedVideos()).Returns(new List<Video>()
			{
				new Video(){ Id = 1},
				new Video(){ Id = 2},
				new Video(){ Id = 3},
			});

			//Act
			var result = _videoservice.GetUnprocessedVideosAsCsv();

			//Assert
			Assert.That(result, Is.EqualTo("1,2,3"));
		}
	}
}
