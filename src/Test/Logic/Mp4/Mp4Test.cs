﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Test.Logic.Mp4
{
    [TestClass]
    [DeploymentItem("Files")]
    public class Mp4Test
    {
        [TestMethod]
        public void Mp4Test1()
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "sample_MP4_SRT.mp4");
            var parser = new Nikse.SubtitleEdit.Logic.Mp4.MP4Parser(fileName);

            var tracks = parser.GetSubtitleTracks();

            Assert.IsTrue(tracks.Count == 1);
            Assert.IsTrue(tracks[0].Mdia.Minf.Stbl.EndTimeCodes.Count == 2);
        }
    }

}
